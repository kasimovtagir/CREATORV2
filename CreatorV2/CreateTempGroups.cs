using CreatorV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class CreateTempGroups : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public CreateTempGroups()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }



        private void CreateTempGroups_Load(object sender, EventArgs e)
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

        private void buttonCreateTempGroup_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = _Actions.CreateTempGroup(comboBoxUserName.Text, comboBoxListGroup.Text, dateTimePicker1.Value);
            comboBoxUserName.Enabled = false; comboBoxListGroup.Enabled = false;
            buttonCreateTempGroup.Enabled = false;
            dateTimePicker1.Enabled = false;
            this.Close();
        }

        private void CreateTempGroups_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
