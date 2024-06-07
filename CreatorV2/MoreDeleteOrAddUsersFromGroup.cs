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
    public partial class MoreDeleteOrAddUsersFromGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        private string _DeleteOrAdd;
        public MoreDeleteOrAddUsersFromGroup(string deleteOrAdd, Actions action, Variables variables)
        {
            InitializeComponent();

            _Variables = variables;
            _Actions = action;
            _DeleteOrAdd = deleteOrAdd;

            if (deleteOrAdd == "Delete")
            {
                buttonDeleteOrAddUsersFromGroup.Text = "Удалить";
            }
            else
            {
                buttonDeleteOrAddUsersFromGroup.Text = "Добавить";
            }
        }

        private void buttonDeleteOrAddUsersFromGroup_Click(object sender, EventArgs e)
        {

        }

        private void MoreDeleteOrAddUsersFromGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }
    }
}
