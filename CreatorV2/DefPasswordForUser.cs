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
    public partial class DefPasswordForUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public DefPasswordForUser()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void DefPasswordForUser_Load(object sender, EventArgs e)
        {
            textBoxDefPassForUser.Text =_Variables._PasswordInAD = _Actions.LoadSettings2("DefPasswordUser");            
        }

        private void buttonSavePAssForUser_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("DefPasswordUser", _Variables._PasswordInAD = textBoxDefPassForUser.Text);
            _Variables.Log.Add("Произведена смена пароля по умолчанию для пользователя.");
            this.Close();
        }
    }
}
