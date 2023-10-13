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

        }

        private void buttonSavePAssForUser_Click(object sender, EventArgs e)
        {
            //_Variables._PasswordInAD = 
        }
    }
}
