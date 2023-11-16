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
            textBoxNetBios.Text = _Variables.NetBios = _Actions.LoadSettings2("netbios");
                       
            string[] namesOU = _Actions.ListOU(textBoxNetBios.Text).ToArray();
            Array.Sort(namesOU);
            // Заполнение ComboBox вариантами
            comboBoxListOU.Items.AddRange(namesOU);

            // Настройка автодополнения
            comboBoxListOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(namesOU);

            // Установка источника автодополнения ComboBox
            comboBoxListOU.AutoCompleteCustomSource = autoCompleteCollection;

            comboBoxListOU.Text = _Variables.OU = _Actions.LoadSettings2("OU"); 
        }

        private void buttonSaveNetBios_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetBios.Text);
            _Actions.SaveSettingsV2("OU", _Variables.NetBios = comboBoxListOU.Text);      
            this.Close();
        }

        private void textBoxNetBios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
