using CreatorV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string[] namesOU = _Actions.ListOU(Domain.GetComputerDomain().ToString()).ToArray();
            Array.Sort(namesOU);
            // Заполнение ComboBox вариантами
            comboBoxListOU.Items.AddRange(namesOU);
            comboBox1.Items.AddRange(namesOU);

            // Настройка автодополнения
            comboBoxListOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollectionListOu = new AutoCompleteStringCollection();
            autoCompleteCollectionListOu.AddRange(namesOU);

            // Установка источника автодополнения ComboBox
            comboBoxListOU.AutoCompleteCustomSource = autoCompleteCollectionListOu;
            comboBox1.AutoCompleteCustomSource = autoCompleteCollectionListOu;
        }

        private void MoveUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Actions.MoveUsersToOU(comboBoxListUser.Text,comboBox1.Text, comboBoxListOU.Text);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBox1.Text = _Variables.OU;

            //_Actions.GetAllUser();
            _Actions.GetAllUser(comboBox1.Text);

            string[] names = _Variables.AllUsersInAD.ToArray();
            Array.Sort(names);
            // Заполнение ComboBox вариантами
            //comboBox1.Items.AddRange(names);
            comboBoxListUser.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxListUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListUser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxListUser.AutoCompleteCustomSource = autoCompleteCollection;           
        }
    }
}
