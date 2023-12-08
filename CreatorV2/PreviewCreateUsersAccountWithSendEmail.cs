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

            switch (_Variables._TypePost)
            {
                case "Сотрудник":
                    foreach (var item in _Variables._ListGroupForAddEmployeer)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "Студент":
                    foreach (var item in _Variables._ListGroupForAddStudent)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "Произвольный":
                    foreach (var item in _Variables._ListGroupForAddArbitrary)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else textBoxListGroup.Text += item + "; ";
                    }
                    break;

                case "СУЗсПФ":
                    foreach (var item in _Variables._ListGroupForAddSUZsPF)
                    {
                        if (item == "")
                        {
                            continue;
                        }
                        else textBoxListGroup.Text += item + "; ";
                    }
                    break;


            }




            if (_Variables._TypePost == "Сотрудник")
            {
                
            }
            else
            {
                
            }
            textBoxMessageMetxt.Text = _Actions.ChangeText("RUS"); // _Variables.TextMessageForSendEMAIL_RUS;
        }

        private void buttonCreateUserinAD_Click(object sender, EventArgs e)
        {
            _Actions.CreateADAccount();

            _Actions.AddUserToDefGroups();

            try
            {
                if (_Actions.CheckCreateUser())
                {
                    _Actions.SendMessage(textBoxMessageMetxt.Text, textBoxSubject.Text);
                    _Variables.Log.Add("Message send!");
                }
                else
                {
                    _Variables.Log.Add("Error, try again!");
                }

            }
            catch (Exception ex)
            {
                _Variables.Log.Add(ex.ToString());
            }

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
