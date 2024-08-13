using CreatorV2.Classes;
using Microsoft.AspNetCore.Http;
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
    public partial class MoreDeleteOrAddUsersFromGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        private string _DeleteOrAdd;
        public MoreDeleteOrAddUsersFromGroup(string deleteOrAdd, Actions action, Variables variables)
        {
            InitializeComponent();

            comboBoxListUser.Items.Clear();
            comboBoxListGroup.Items.Clear();

            _Variables = variables;
            _Actions = action;
            _DeleteOrAdd = deleteOrAdd;

            comboBoxListGroup = _Actions.ConfigureComboBox(comboBoxListGroup, _Actions.GetGroups, _Variables.ListAllGroups);
            
            if (deleteOrAdd == "Delete")
            {
                buttonDeleteOrAddUsersFromGroup.Text = "Удалить";
                
                this.Text = "Удалить пользователей из группы";
            }
            else
            {
                buttonDeleteOrAddUsersFromGroup.Text = "Добавить";
                comboBoxListUser = _Actions.ConfigureComboBox(comboBoxListUser, _Actions.GetAllUser, _Variables.AllUsersInAD);
                this.Text = "Добавить пользователей в группу.";
            }
        }



        private void buttonDeleteOrAddUsersFromGroup_Click(object sender, EventArgs e)
        {
            string groupName = comboBoxListGroup.Text;

            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Выберите группу.");
            }
            else if (listBoxChoosedUser.Items.Count == 0)
            {
                MessageBox.Show($"Нет пользователей для добавления в группы {groupName}");
            }
            else
            {
                foreach (var username in listBoxChoosedUser.Items)
                {
                    if (string.IsNullOrEmpty(username.ToString()))
                    {
                        MessageBox.Show("Пустое значение.");
                        continue;
                    }
                    else
                    {
                        if (_DeleteOrAdd == "Delete")
                        {
                            _Actions.RemoveUserFroumGroup(username.ToString(), groupName);
                        }
                        else
                        {
                            string usernames = _Actions.GetSamAccountNameByDisplayName(username.ToString());
                            _Actions.AddUserToGroup(usernames, comboBoxListGroup.Text);
                        }
                    }
                }
                this.Close();
            }
        }

        private void MoreDeleteOrAddUsersFromGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void MoreDeleteOrAddUsersFromGroup_Load(object sender, EventArgs e)
        {
            
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

        private void comboBoxListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_DeleteOrAdd =="Delete")
            {
                comboBoxListUser.Items.Clear();
                List<string> listUserInGroup = _Actions.showUsersInGroup(comboBoxListGroup.Text);

                for (int i = 0; i < listUserInGroup.Count; i++)
                {
                    listUserInGroup[i] = Regex.Replace(listUserInGroup[i], @"\s*\([^()]*\)", "");
                }

                comboBoxListUser = _Actions.ConfigureComboBox(comboBoxListUser, _Actions.GetGroups, listUserInGroup);
            }            
        }
    }
}
