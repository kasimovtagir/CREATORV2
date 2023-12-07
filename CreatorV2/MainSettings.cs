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
using System.DirectoryServices.ActiveDirectory;

namespace CreatorV2
{
    public partial class MainSettings : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public MainSettings()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void buttonSaveMainSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNetbios.Text) || string.IsNullOrEmpty(comboBoxListOU.Text))
            {
                MessageBox.Show("Поля NETBIOS и OU обязательны к заполнению.");
            }
            else
            {
                _Actions.SaveSettingsV2("AdminUserName", _Variables._FIOForSendEmail = textBoxUserName.Text.Trim());
                _Actions.SaveSettingsV2("AdminEmail", _Variables._EmailForSendEmail = textBoxEmail.Text.Trim());
                _Actions.SaveSettingsV2("AdminPassword", _Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxUserPassword.Text.Trim()));
                _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetbios.Text.Trim());

                _Actions.SaveSettingsV2("OU", _Variables.OU = comboBoxListOU.Text);
                this.Close();
            }
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
            textBoxNetbios.Text = Domain.GetComputerDomain().ToString();
            //_Variables.OU = _Actions.ListOU(textBoxNetbios.Text);

            string[] namesOU = _Actions.ListOU(textBoxNetbios.Text).ToArray();
            Array.Sort(namesOU);
            // Заполнение ComboBox вариантами
            comboBoxListOU.Items.AddRange(namesOU);

            // Настройка автодополнения
            comboBoxListOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(namesOU);

            // Установка источника автодополнения ComboBox
            comboBoxListOU.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxUserPassword.UseSystemPasswordChar = false;
            }
            else textBoxUserPassword.UseSystemPasswordChar = true;
        }
    }
}
