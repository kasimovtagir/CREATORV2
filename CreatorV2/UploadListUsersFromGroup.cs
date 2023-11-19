using CreatorV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class UploadListUsersFromGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public UploadListUsersFromGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }


        private void buttonUploadListUser_Click(object sender, EventArgs e)
        {
            string path = $@"listAllUsersIn_{comboBoxListGroup.Text}.txt";

            List<string> results = new List<string>();

            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    results = _Actions.showUsersInGroup(comboBoxListGroup.Text);
                    sw.WriteLine(comboBoxListGroup.Text);
                    foreach (var items in results)
                    {
                        sw.WriteLine($"\t{items}");
                    }
                }
                catch (Exception ex) { MessageBox.Show($"error {ex}"); }
            }
            _Variables.Log.Add($"Готово. Вся информация выгружена в файл listAllUsersIn_{comboBoxListGroup.Text}.txt");

            this.Close();
        }

        private void UploadListUsersFromGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();
            string[] group_names = _Variables.ListAllGroups.ToArray(); // Data.AllGroupsInAD.ToArray();
            Array.Sort(group_names);
            // Заполнение ComboBox вариантами
            comboBoxListGroup.Items.AddRange(group_names);

            // Настройка автодополнения
            comboBoxListGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection2 = new AutoCompleteStringCollection();
            autoCompleteCollection2.AddRange(group_names);

            // Установка источника автодополнения ComboBox
            comboBoxListGroup.AutoCompleteCustomSource = autoCompleteCollection2;
        }

        private void UploadListUsersFromGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
        }
    }
}
