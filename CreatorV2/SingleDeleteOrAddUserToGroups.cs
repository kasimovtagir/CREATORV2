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
    public partial class SingleDeleteOrAddUserToGroups : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        private string _DeleteOrAdd;
        public SingleDeleteOrAddUserToGroups(string deleteOrAdd, Actions action, Variables variables)
        {
            InitializeComponent();

            _Variables = variables;
            _Actions = action;
            _DeleteOrAdd = deleteOrAdd;

            if (deleteOrAdd == "Delete")
            {
                button1.Text = "Удалить";
            }
            else
            {
                button1.Text = "Добавить";
            }
        }

        private void SingleDeleteOrAddUserToGroups_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;

            comboBoxUserName = _Actions.ConfigureComboBox(comboBoxUserName, _Actions.GetAllUser, _Variables.AllUsersInAD);

            comboBoxGroup = _Actions.ConfigureComboBox(comboBoxGroup, _Actions.GetGroups, _Variables.ListAllGroups);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = comboBoxUserName.Text; // Замените на имя пользователя, которого вы хотите удалить из группы
            string groupName = comboBoxGroup.Text; // Замените на имя группы, из которой вы хотите удалить пользователя

            if (comboBoxUserName.Text == string.Empty | comboBoxGroup.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые, пожалуйста введите необходимые данные.");
            }
            else
            {
                if (_DeleteOrAdd == "Delete")
                {
                    _Actions.RemoveUserFroumGroup(username, groupName);

                    this.Close();
                }
                else
                {
                    username = _Actions.GetSamAccountNameByDisplayName(username);
                    _Actions.AddUserToGroup(username, comboBoxGroup.Text);

                    this.Close();
                }
            }
        }        

        private void SingleDeleteOrAddUserToGroups_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
