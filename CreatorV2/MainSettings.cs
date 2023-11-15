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
            _Actions.SaveSettingsV2("AdminUserName", _Variables._FIOForSendEmail = textBoxUserName.Text.Trim());
            _Actions.SaveSettingsV2("AdminEmail", _Variables._EmailForSendEmail = textBoxEmail.Text.Trim());
            _Actions.SaveSettingsV2("AdminPassword", _Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxUserPassword.Text.Trim()));
            _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetbios.Text.Trim());
            this.Close();
        }
    }
}
