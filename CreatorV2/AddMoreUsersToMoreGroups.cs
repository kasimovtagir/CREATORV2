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
    public partial class AddMoreUsersToMoreGroups : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public AddMoreUsersToMoreGroups()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxListUser.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBox1.Items.Contains(comboBoxListUser.Text))
                {
                    listBox1.Items.Add(comboBoxListUser.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListUser.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void buttonMoreAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 | listBox2.Items.Count == 0)
            {
                MessageBox.Show("Поля пустые.");
            }
            else
            {
                foreach (var itemListGroup in listBox2.Items)
                {
                    foreach (var username in listBox1.Items)
                    {
                        if (string.IsNullOrEmpty(username.ToString()))
                        {
                            MessageBox.Show("Пустое значение.");
                            continue;
                        }
                        else
                        {
                            string usernames = _Actions.GetSamAccountNameByDisplayName(username.ToString());
                            //MessageBox.Show($"{usernames} to {itemListGroup}");
                            _Actions.AddUserToGroup(usernames, itemListGroup.ToString());
                        }
                    }
                }
            }
            this.Close();
        }

        private void AddMoreUsersToMoreGroups_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray(); //Data.AllUsersInAD.ToArray();
            Array.Sort(names);
            // Заполнение ComboBox вариантами
            //comboBox1.Items.AddRange(names);
            comboBoxListUser.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxListUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListUser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxListUser.AutoCompleteCustomSource = autoCompleteCollection;


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

        private void buttonAddGroups_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxListGroup.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBox2.Items.Contains(comboBoxListGroup.Text))
                {
                    listBox2.Items.Add(comboBoxListGroup.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListGroup.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void AddMoreUsersToMoreGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            string choosed = string.Empty;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                choosed = listBox1.Items[selectedIndex].ToString().Trim();
                // Удаляем позицию из ListBox
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox2.SelectedIndex;
            string choosed = string.Empty;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                choosed = listBox2.Items[selectedIndex].ToString().Trim();
                // Удаляем позицию из ListBox
                listBox2.Items.RemoveAt(selectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
