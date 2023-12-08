using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CreatorV2
{
    public partial class PreviewCreateUsersAccountWithoutSendEmail : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public PreviewCreateUsersAccountWithoutSendEmail()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccountWithoutSendEmail_Click(object sender, EventArgs e)
        {
            _Actions.CreateADAccount();
            _Actions.AddUserToDefGroups();
            this.Close();
        }

        private void PreviewCreateUsersAccountWithoutSendEmail_Load(object sender, EventArgs e)
        {
            textBoxAccount.Text = _Variables._SamAccountInAD.ToLower() + "@metalab.ifmo.ru";
            textBoxPassword.Text = _Variables._PasswordInAD;

            switch (_Variables._TypePost)
            {
                case "Сотрудник":
                    foreach (var item in _Variables._ListGroupForAddEmployeer)
                    {
                        textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "Студент":
                    foreach (var item in _Variables._ListGroupForAddStudent)
                    {
                        textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "Произвольный":
                    foreach (var item in _Variables._ListGroupForAddArbitrary)
                    {
                        textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "СУЗсПФ":
                    foreach (var item in _Variables._ListGroupForAddSUZsPF)
                    {
                        textBoxListGroup.Text += item + "; ";
                    }
                    break;
            }

           

        }

        private void checkBoxShwoPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShwoPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
