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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class ListGroup : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}
        public ListGroup()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void buttonSaveSettingsListGroup_Click(object sender, EventArgs e)
        {
            string list = string.Empty;
            foreach (string item in listBoxListGroupForEmployees.Items)
            {
                _Variables._ListGroupForAddEmployeer.Add(item);
                list += item + ";";
            }
            _Actions.SaveSetting(list, 4);

        }

        private void ListGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();
            //выгрузка списка групп для сотрудника
            string[] listGroups = _Actions.LoadSetting(4).Split(";");
            Array.Sort(listGroups);
            foreach (string listGroup in listGroups)
            {
                if (listGroup == "")
                {
                    continue;
                }
                else
                {
                    _Variables._ListGroupForAddEmployeer.Add(listGroup);
                    listBoxListGroupForEmployees.Items.Add(listGroup);
                }
            }

            label7.Text = "*Нажми 2 раза на группу в списке и она буде удалена из списка.";
            label7.BackColor = Color.Red;


            Array.Sort(_Variables.ListAllGroups.ToArray());

            System.Windows.Forms.ComboBox[] list = { comboBoxListGroupForEmployees, comboBoxListGroupForStudent, comboBoxListGroupForSUZsPF };

            foreach (var listTypesGroup in list)
            {
                UploadAllGroups(listTypesGroup);
            }

            label4.Text = $"Количество группу {listBoxListGroupForEmployees.Items.Count}";
            label5.Text = $"Количество группу {listBoxListGroupForStudent.Items.Count}";
            label6.Text = $"Количество группу {listBoxGroupForSUZsPF.Items.Count}";
        }

        /// <summary>
        /// Метод для записи в ComboBox список всех групп
        /// </summary>
        /// <param name="comboBox"></param>
        public void UploadAllGroups(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.AddRange(_Variables.ListAllGroups.ToArray());
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollectionForGroups3 = new AutoCompleteStringCollection();
            autoCompleteCollectionForGroups3.AddRange(_Variables.ListAllGroups.ToArray());

            // Установка источника автодополнения ComboBox
            comboBox.AutoCompleteCustomSource = autoCompleteCollectionForGroups3;
        }

        private void buttonAddToListGroupForEmployees_Click(object sender, EventArgs e)
        {
            string[] allGroups = new string[listBoxListGroupForEmployees.Items.Count];

            listBoxListGroupForEmployees.Items.CopyTo(allGroups, 0);

            if (Array.Exists(allGroups, group => group == comboBoxListGroupForEmployees.Text))
            {
                MessageBox.Show("Такая группа уже добавлена.");
            }
            else
            {
                listBoxListGroupForEmployees.Items.Add(comboBoxListGroupForEmployees.Text);
                label4.Text = $"Количество групп: {listBoxListGroupForEmployees.Items.Count}";
            }
            if (comboBoxListGroupForEmployees.Text == "")
            {
                MessageBox.Show("Выбери группу.");
            }
        }
    }
}
