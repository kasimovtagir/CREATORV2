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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CreatorV2
{
    public partial class DeleteAllGroupsFromMoreUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public DeleteAllGroupsFromMoreUsers()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }
        private void DeleteAllGroupsFromMoreUsers_Load(object sender, EventArgs e)
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

        private void DeleteAllGroupsFromMoreUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void buttonAddUserToList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxUserName.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxChoosedUser.Items.Contains(comboBoxUserName.Text))
                {
                    listBoxChoosedUser.Items.Add(comboBoxUserName.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxUserName.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var ListUser in listBoxChoosedUser.Items)
            {
                ListBox list = new ListBox();
                List<string> listgoups = new List<string>();
                list = _Actions.GetListGroupUsers(ListUser.ToString()) ;
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

                foreach (var listgroupsForDeleted in listAllGroup)
                {
                    _Actions.RemoveUserFroumGroup(ListUser.ToString(), listgroupsForDeleted.ToString());
                }
                
            }
        }
    }
}
