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

        }

        private void ChangePasswordForUser_Load(object sender, EventArgs e)
        {

        }
    }
}
