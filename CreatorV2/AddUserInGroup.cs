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
    public partial class AddUserInGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public AddUserInGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void AddUserInGroup_Load(object sender, EventArgs e)
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
            comboBoxGroup.Items.AddRange(group_names);

            // Настройка автодополнения
            comboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection2 = new AutoCompleteStringCollection();
            autoCompleteCollection2.AddRange(group_names);

            // Установка источника автодополнения ComboBox
            comboBoxGroup.AutoCompleteCustomSource = autoCompleteCollection2;
        }

        private void buttonAddUserToGroup_Click(object sender, EventArgs e)
        {
            if (comboBoxUserName.Text == string.Empty | comboBoxGroup.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые, пожалуйста введите необходимые данные.");
            }
            else
            {
                _Actions.AddUserToGroup(comboBoxUserName.Text, comboBoxGroup.Text);
                //_Variables.Log.Add($"Пользователь {comboBoxUserName.Text} добавлен в группу {comboBoxGroup.Text}") ;
            }

            this.Close();

        }

        private void AddUserInGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
