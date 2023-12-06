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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CreatorV2
{
    public partial class PreviewCreateUsersAccountWithSendEmail : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}

        public PreviewCreateUsersAccountWithSendEmail()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void PreviewCreateUsersAccountWithSendEmail_Load(object sender, EventArgs e)
        {

            checkBoxRUS.Checked = true;
            textBoxTo.Text = _Variables._UsersEmail;
            textBoxFrom.Text = $"{_Variables._FIOForSendEmail}, {_Variables._EmailForSendEmail}";
            textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
            if (_Variables._TypePost == "Сотрудник")
            {
                foreach (var item in _Variables._ListGroupForAddEmployeer)
                {
                    if (item == "")
                    {
                        continue;
                    }
                    else textBoxListGroup.Text += item + "; ";
                }
            }
            else
            {
                foreach (var item in _Variables._ListGroupForAddStudent)
                {
                    if (item == "")
                    {
                        continue;
                    }
                    else textBoxListGroup.Text += item + "; ";
                }
            }
            textBoxMessageMetxt.Text = _Actions.ChangeText("RUS"); // _Variables.TextMessageForSendEMAIL_RUS;
        }

        private void buttonCreateUserinAD_Click(object sender, EventArgs e)
        {
            _Actions.CreateADAccount();
            this.Close();
        }

        private void checkBoxENG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxENG.Checked)
            {
                checkBoxRUS.Checked = false;
                label3.Text = "Subject: ";
                label4.Text = "List group: ";
                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_ENG;
                textBoxMessageMetxt.Text = _Actions.ChangeText("ENG"); //_Variables.TextMessageForSendEMAIL_ENG;
            }
        }

        private void checkBoxRUS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRUS.Checked)
            {
                checkBoxENG.Checked = false;
                label3.Text = "Тема письма: ";
                label4.Text = "Список групп: ";
                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
                textBoxMessageMetxt.Text = _Actions.ChangeText("RUS");// _Variables.TextMessageForSendEMAIL_RUS;
            }
        }
    }
}
