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
    public partial class ChangePasswordForUser : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public ChangePasswordForUser()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void buttonSaveNewPasswordForUser_Click(object sender, EventArgs e)
        {
             
            //Actions.ChangePasswordForDefault(comboBox1.Text, txtBoxPassword.Text);
            this.Close();
        }

        private void ChangePasswordForUser_Load(object sender, EventArgs e)
        {
            textBoxNewPassword.Text = _Variables._PasswordInAD;
            string[] names = _Variables.AllUsersInAD.ToArray();  
            Array.Sort(names);
            // Заполнение ComboBox вариантами
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxNewPassword.UseSystemPasswordChar = false;
            }
            else textBoxNewPassword.UseSystemPasswordChar = true;
        }
    }
}
