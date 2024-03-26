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

namespace CreatorV2
{
    public partial class AddMoreGroupsToUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public AddMoreGroupsToUser()
        {
            InitializeComponent();
            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddMoreGroupsToUser_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray(); //Data.AllUsersInAD.ToArray();
            Array.Sort(names);
            // Заполнение ComboBox вариантами
            //comboBox1.Items.AddRange(names);
            comboBoxListGroups.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxListGroups.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListGroups.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxListGroups.AutoCompleteCustomSource = autoCompleteCollection;


            _Actions.GetGroups();
            string[] group_names = _Variables.ListAllGroups.ToArray(); // Data.AllGroupsInAD.ToArray();
            Array.Sort(group_names);
            // Заполнение ComboBox вариантами
            comboBoxListUser.Items.AddRange(group_names);

            // Настройка автодополнения
            comboBoxListUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListUser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection2 = new AutoCompleteStringCollection();
            autoCompleteCollection2.AddRange(group_names);

            // Установка источника автодополнения ComboBox
            comboBoxListUser.AutoCompleteCustomSource = autoCompleteCollection2;
        }

        private void buttonAddUserToList_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь в comboBoxListUser
            if (string.IsNullOrEmpty(comboBoxListUser.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxChoosedUser.Items.Contains(comboBoxListUser.Text))
                {
                    listBoxChoosedUser.Items.Add(comboBoxListUser.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListUser.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }
    }
}
