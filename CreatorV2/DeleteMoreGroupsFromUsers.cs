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
    public partial class DeleteMoreGroupsFromUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public DeleteMoreGroupsFromUsers()
        {
            InitializeComponent();
            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            string username = comboBoxUserName.Text; // Замените на имя пользователя, которого вы хотите удалить из группы
                        string groupName = comboBoxListGroup.Text; // Замените на имя группы, из которой вы хотите удалить пользователя

                        _Actions.RemoveUserFroumGroup(username, groupName);
                        this.Close();*/

            string username = comboBoxListUser.Text;
            foreach (var itemGroup in listBoxChoosedGroup.Items)
            {
                if (string.IsNullOrEmpty(itemGroup.ToString()))
                {
                    MessageBox.Show("Пустое значение.");
                    continue;
                }
                else
                {
                    _Actions.RemoveUserFroumGroup(username, itemGroup.ToString());
                }
            }

            this.Close();
        }

        private void comboBoxListUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = new ListBox();
            List<string> listgoups = new List<string>();
            list = _Actions.GetListGroupUsers(comboBoxListUser.Text);
            list.Sorted = true;
            foreach (var item in list.Items)
            {
                string nameGroup = item.ToString();
                nameGroup = nameGroup.Replace("CN=", "");
                //listBox1.Items.Add(nameGroup);
                listgoups.Add(nameGroup);
            }
            string[] listAllUser = listgoups.ToArray();
            Array.Sort(listAllUser);
            comboBoxListGroup.Items.AddRange(listAllUser);
            comboBoxListGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollectionForGroups = new AutoCompleteStringCollection();
            autoCompleteCollectionForGroups.AddRange(listAllUser);

            // Установка источника автодополнения ComboBox
            comboBoxListGroup.AutoCompleteCustomSource = autoCompleteCollectionForGroups;
        }

        private void buttonAddUserToList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxListGroup.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxChoosedGroup.Items.Contains(comboBoxListGroup.Text))
                {
                    listBoxChoosedGroup.Items.Add(comboBoxListGroup.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListGroup.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void DeleteMoreGroupsFromUsers_Load(object sender, EventArgs e)
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
        }

        private void listBoxChoosedGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxChoosedGroup.SelectedIndex;
            string choosed = string.Empty;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                choosed = listBoxChoosedGroup.Items[selectedIndex].ToString().Trim();
                // Удаляем позицию из ListBox
                listBoxChoosedGroup.Items.RemoveAt(selectedIndex);
            }
        }

        private void DeleteMoreGroupsFromUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
