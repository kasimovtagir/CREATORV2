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
    public partial class MoveUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public MoveUsers()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void MoveUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
