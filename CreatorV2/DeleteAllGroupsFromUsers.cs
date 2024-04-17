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
    public partial class DeleteAllGroupsFromUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public DeleteAllGroupsFromUsers()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void DeleteAllGroupsFromUsers_Load(object sender, EventArgs e)
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

        private void DeleteAllGroupsFromUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = new ListBox();
            List<string> listgoups = new List<string>();
            list = _Actions.GetListGroupUsers(comboBoxUserName.Text);
            list.Sorted = true;
            foreach (var item in list.Items)
            {
                string nameGroup = item.ToString();
                nameGroup = nameGroup.Replace("CN=", "");
                //listBox1.Items.Add(nameGroup);
                listgoups.Add(nameGroup);
            }
            string[] listAllGroup = listgoups.ToArray();
            Array.Sort(listAllGroup);
            foreach (var listGroups in listAllGroup)
            {
                listBoxAllGroupsFromUsers.Items.Add(listGroups);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = comboBoxUserName.Text; // Замените на имя пользователя, которого вы хотите удалить из группы
            //string groupName = comboBoxListGroup.Text; // Замените на имя группы, из которой вы хотите удалить пользователя

            foreach (var listGroup in listBoxAllGroupsFromUsers.Items)
            {
                _Actions.RemoveUserFroumGroup(username, listGroup.ToString());
            }
            this.Close();
        }

        private void listBoxAllGroupsFromUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxAllGroupsFromUsers.SelectedIndex;
            string choosed = string.Empty;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                choosed = listBoxAllGroupsFromUsers.Items[selectedIndex].ToString().Trim();
                // Удаляем позицию из ListBox
                listBoxAllGroupsFromUsers.Items.RemoveAt(selectedIndex);
            }

        }
    }
}
