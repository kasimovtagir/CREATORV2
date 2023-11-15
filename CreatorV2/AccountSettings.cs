/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;*/

using CreatorV2.Classes;

namespace CreatorV2
{
    public partial class AccountSettings : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public AccountSettings()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            //выгрузить данный из файла 
            textBoxNameLastName.Text = _Variables._FIOForSendEmail = _Actions.LoadSettings2("AdminUserName");
            textBoxEmail.Text = _Variables._EmailForSendEmail = _Actions.LoadSettings2("AdminEmail");
            textBoxPassword.Text = _Actions.Decrypt(_Variables._PasswordForSendEmail = _Actions.LoadSettings2("AdminPassword"));
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            //сохранения в файл 
            /*            
             *            _Actions.SaveSetting(_Variables._FIOForSendEmail = textBoxNameLastName.Text.Trim(),0);
             *            
                        _Actions.SaveSetting(_Variables._EmailForSendEmail = textBoxEmail.Text.Trim(),1);
                        _Actions.SaveSetting(_Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxPassword.Text.Trim()),2);
            */

            _Actions.SaveSettingsV2("AdminUserName", _Variables._FIOForSendEmail = textBoxNameLastName.Text.Trim());
            _Actions.SaveSettingsV2("AdminEmail", _Variables._EmailForSendEmail = textBoxEmail.Text.Trim());
            _Actions.SaveSettingsV2("AdminPassword", _Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxPassword.Text.Trim()));


            this.Close();
        }
    }
}
