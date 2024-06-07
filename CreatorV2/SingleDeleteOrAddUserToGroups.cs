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
    public partial class SingleDeleteOrAddUserToGroups : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        private string _DeleteOrAdd;
        public SingleDeleteOrAddUserToGroups(string deleteOrAdd, Actions action, Variables variables)
        {
            InitializeComponent();

            _Variables = variables;
            _Actions = action;
            _DeleteOrAdd = deleteOrAdd;

            if (deleteOrAdd == "Delete".ToLower())
            {
                button1.Text = "Удалить";
            }
            else
            {
                button1.Text = "Добавить";
            }
        }

        private void SingleDeleteOrAddUserToGroups_Load(object sender, EventArgs e)
        {
            ConfigureComboBox(comboBoxUserName, _Actions.GetAllUser, _Variables.AllUsersInAD);
            ConfigureComboBox(comboBoxGroup, _Actions.GetGroups, _Variables.ListAllGroups);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void ConfigureComboBox(ComboBox comboBox, Action getDataAction, IEnumerable<string> dataSource)
        {
            getDataAction();
            string[] items = dataSource.ToArray();
            Array.Sort(items);
            comboBox.Items.AddRange(items);

            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(items);
            comboBox.AutoCompleteCustomSource = autoCompleteCollection;
        }
    }
}
