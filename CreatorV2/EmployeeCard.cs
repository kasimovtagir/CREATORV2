using CreatorV2.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class EmployeeCard : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public EmployeeCard()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void EmployeeCard_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray(); //Data.AllUsersInAD.ToArray();
            Array.Sort(names);
            // Заполнение ComboBox вариантами
            //comboBox1.Items.AddRange(names);
            comboBoxUserName.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxUserName.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void buttonShowEmployeeCard_Click(object sender, EventArgs e)
        {
            List<string> UserInformation = _Actions.GetUserInformationAD(comboBoxUserName.Text);

            foreach (var item in UserInformation)
            {
                listBox1.Items.Add(item.ToString());
            }

            ListBox listGroupUser = _Actions.GetListGroupUsers(comboBoxUserName.Text);
            int countsGroup = listGroupUser.Items.Count;
            List<string> values = new List<string>();

            foreach (var item in listGroupUser.Items)
            {
                values.Add(item.ToString());
            }

            // Делим общее количество значений на 4
            int chunkSize = countsGroup / 4;

            // Используем LINQ для выборки значений в четыре группы
            var groupedValues = values.Select((value, index) => new { Value = value, Group = index / chunkSize })
                                      .GroupBy(item => item.Group, item => item.Value)
                                      .Select(group => string.Join("\t", group));

            // Выводим значения в ListBox
            foreach (var group in groupedValues)
            {
                string nameGroup = group.ToString();
                nameGroup = nameGroup.Replace("CN=", "");
                textBox1.Text += $"{nameGroup} \n";
            }
        }

        private void EmployeeCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
