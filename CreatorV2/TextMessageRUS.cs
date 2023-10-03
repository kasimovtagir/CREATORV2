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
    public partial class TextMessageRUS : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public TextMessageRUS()
        {
            InitializeComponent();
        }

        private void TextMessageRUS_Load(object sender, EventArgs e)
        {
            if(checkBoxENGText.Checked)
            {
                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_ENG;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_ENG;
            }
            else
            {
                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_RUS;
            }

            label3.ForeColor = Color.Red;
            label3.Text = "*В текста ОБЯЗАТЕЛЬНО должны быть следующие переменные: \nADName - вместо этого текста будет вставлен логин пользователя \nADPassword - вместо этого текста будет написан пароль пользователя.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxRussianText.Checked)
            {
                _Variables.SubjectTextMessageForSendEmail_RUS =textBoxSubject.Text;
                _Variables.TextMessageForSendEMAIL_RUS =textBoxText.Text;
            }
            else
            {
                _Variables.SubjectTextMessageForSendEmail_ENG =textBoxSubject.Text;
                _Variables.TextMessageForSendEMAIL_ENG =textBoxText.Text;
            }
            this.Close();
        }

        private void checkBoxENGText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxENGText.Checked)
            {
                checkBoxRussianText.Checked = false;
                label1.Text = "Subject";
                label2.Text = "Text message";

                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_ENG;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_ENG;

            }
        }

        private void checkBoxRussianText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRussianText.Checked)
            {
                checkBoxENGText.Checked = false;
                label1.Text = "Тема письма";
                label2.Text = "Текст письма";

                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_RUS;
            }
        }
    }
}
