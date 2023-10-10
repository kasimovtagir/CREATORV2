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
            SaveList(listBoxListGroupForEmployees, 4, _Variables._ListGroupForAddEmployeer);
            SaveList(listBoxListGroupForStudent, 5, _Variables._ListGroupForAddStudent);
            this.Close();
        }


        /// <summary>
        /// метод для сохранения списка из listbox'а в файл 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="IndexLine"></param>
        /// <param name="listGroups"></param>
        public void SaveList(ListBox listBox, int IndexLine, List<string> listGroups)
        {
            string list = string.Empty;
            foreach (string item in listBox.Items)
            {
                listGroups.Add(item);
                list += item + ";";
            }
            _Actions.SaveSetting(list, IndexLine);
        }

        /// <summary>
        /// группа для выгрузки списка групп из файла с настройками 
        /// </summary>
        /// <param name="listGroup"></param>
        /// <param name="listBoxGroup"></param>
        /// <param name="indexLine"></param>
        public void uploadListGroup (List<string> listGroup, ListBox listBoxGroup, int indexLine)
        {
            //выгрузка списка групп для сотрудника
            string[] listGroups = _Actions.LoadSetting(indexLine).Split(";");
            Array.Sort(listGroups);
            foreach (string item in listGroups)
            {
                if (item == "")
                {
                    continue;
                }
                else
                {
                    listGroup.Add(item);
                    listBoxGroup.Items.Add(item);
                }
            }
        }

        private void ListGroup_Load(object sender, EventArgs e)
        {
            //выгрузка списка всех групп 
            _Actions.GetGroups();

            uploadListGroup(_Variables._ListGroupForAddEmployeer, listBoxListGroupForEmployees, 4);
            uploadListGroup(_Variables._ListGroupForAddStudent, listBoxListGroupForStudent, 5);

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
            AddGroupInList(listBoxListGroupForEmployees, comboBoxListGroupForEmployees, label4);
        }

        private void buttonAddGroupToListGroupForStudent_Click(object sender, EventArgs e)
        {
            AddGroupInList(listBoxListGroupForStudent, comboBoxListGroupForStudent, label5);
        }


        /// <summary>
        /// метод для добавления группы в списко групп по умолчанию 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="comboBox"></param>
        /// <param name="label"></param>
        public void AddGroupInList(ListBox listBox, System.Windows.Forms.ComboBox comboBox, Label label)
        {
            string[] allGroups = new string[listBox.Items.Count];

            listBox.Items.CopyTo(allGroups, 0);

            if (Array.Exists(allGroups, group => group == comboBox.Text))
            {
                MessageBox.Show("Такая группа уже добавлена.");
            }
            else
            {
                listBox.Items.Add(comboBox.Text);
                label.Text = $"Количество групп: {listBox.Items.Count}";
            }
            if (comboBox.Text == "")
            {
                MessageBox.Show("Выбери группу.");
            }
        }
    }
}
