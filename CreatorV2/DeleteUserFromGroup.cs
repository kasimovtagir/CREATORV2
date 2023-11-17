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
    public partial class DeleteUserFromGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public DeleteUserFromGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }


        private void buttonDeleteUserFromGroup_Click(object sender, EventArgs e)
        {
            string username = comboBoxUserName.Text; // Замените на имя пользователя, которого вы хотите удалить из группы
            string groupName = comboBoxListGroup.Text; // Замените на имя группы, из которой вы хотите удалить пользователя

            _Actions.RemoveUserFroumGroup(username, groupName);
            this.Close();
            //comboBoxc.Text = string.Empty; comboBox2.Text = string.Empty;
        }

        private void DeleteUserFromGroup_Load(object sender, EventArgs e)
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

        private void DeleteUserFromGroup_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
