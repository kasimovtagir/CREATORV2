/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;*/

namespace CreatorV2
{
    public partial class DomainSettings : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public DomainSettings()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }


        private void DomainSettings_Load(object sender, EventArgs e)
        {
            textBoxNetBios.Text = _Variables.NetBios=_Actions.LoadSetting(3);            
        }

        private void buttonSaveNetBios_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetBios.Text);
            //_Actions.SaveSetting(_Variables.NetBios = textBoxNetBios.Text,3);            
            this.Close();
        }
    }
}
