/*using CreatorV2.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;*/

using System.Reflection.Emit;
using System.Windows.Forms;

namespace CreatorV2
{
    public partial class ListGroup : Form
    {
        public Classes.Variables _Variables;// {get;set;}
        public Classes.Actions _Actions;// { get;set;}

        public string typePost;
        public List<string> groups = new List<string>();

        public ListGroup()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void buttonSaveSettingsListGroup_Click(object sender, EventArgs e)
        {
            _Variables._ListGroupForAddEmployeer.Clear();
            _Variables._ListGroupForAddStudent.Clear();
            _Variables._ListGroupForAddArbitrary.Clear();
            _Variables._ListGroupForAddSUZsPF.Clear();

            if (typePost == "Произвольный" || typePost == "СУЗсПФ")
            {
                foreach (string group in listBox1.Items)
                {
                    if (string.IsNullOrEmpty(group))
                    {
                        continue;
                    }
                    if (typePost == "Произвольный")
                    {
                        _Variables._ListGroupForAddArbitrary.Add(group);
                    }
                    else _Variables._ListGroupForAddSUZsPF.Add(group);
                }
            }
            else SaveList(listBox1, typePost, groups);


            /*SaveList(listBox1, "ListGroupForEmplyees", _Variables._ListGroupForAddEmployeer);
            SaveList(listBoxListGroupForStudent, "ListGroupForStudent", _Variables._ListGroupForAddStudent);*/
            //this.Close();
        }


        /// <summary>
        /// метод для сохранения списка из listbox'а в файл 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="IndexLine"></param>
        /// <param name="listGroups"></param>
        public void SaveList(ListBox listBox, string IndexLine, List<string> listGroups)
        {
            string list = string.Empty;
            foreach (string item in listBox.Items)
            {
                listGroups.Add(item);
                list += item + ";";
            }
            _Actions.SaveSettingsV2(IndexLine, list);
            //_Actions.SaveSetting(list, IndexLine);
        }

        /// <summary>
        /// группа для выгрузки списка групп из файла с настройками 
        /// </summary>
        /// <param name="listGroup"></param>
        /// <param name="listBoxGroup"></param>
        /// <param name="indexLine"></param>
        public void uploadListGroup(List<string> listGroup, ListBox listBoxGroup, string whatneed)
        {
            //выгрузка списка групп для сотрудника
            //string[] listGroups = _Actions.LoadSetting(indexLine).Split(";");
            string[] listGroups;
            if (whatneed == "Произвольный" || whatneed == "СУЗсПФ")
            {
                listGroups = _Variables._ListGroupForAddArbitrary.ToArray();
                foreach (var item in listGroups)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        continue;
                    }
                    else listBoxGroup.Items.Add(item.TrimStart());
                }

                //listGroups =listGroups.ToArray();
            }
            else listGroups = _Actions.LoadSettings2(whatneed).Split(";");

            Array.Sort(listGroups);
            foreach (string item in listGroups)
            {
                if (item == "")
                {
                    continue;
                }
                else
                {
                    listGroup.Add(item.TrimStart());
                    listBoxGroup.Items.Add(item);
                }
            }
        }





        private void ListGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();


            /*uploadListGroup(_Variables._ListGroupForAddEmployeer, listBoxListGroupForEmployees, "ListGroupForEmplyees");
            uploadListGroup(_Variables._ListGroupForAddStudent, listBoxListGroupForStudent, "ListGroupForStudent");
            uploadListGroup(_Variables._ListGroupForAddSUZsPF, listBox1, "Arbitrary");
            uploadListGroup(_Variables._ListGroupForAddSUZsPF, listBox1, "SUZsPF");*/

            /* label7.Text = "*Нажми 2 раза на группу в списке и она буде удалена из списка.";
             label7.BackColor = Color.Red;*/
            UploadAllGroups(comboBox2);

            /*
                        Array.Sort(_Variables.ListAllGroups.ToArray());

                        System.Windows.Forms.ComboBox[] list = { comboBoxListGroupForEmployees, comboBoxListGroupForStudent, comboBoxListGroupForSUZsPF };

                        foreach (var listTypesGroup in list)
                        {
                            UploadAllGroups(listTypesGroup);
                        }

                        label4.Text = $"Количество группу {listBoxListGroupForEmployees.Items.Count}";
                        label5.Text = $"Количество группу {listBoxListGroupForStudent.Items.Count}";
                        label6.Text = $"Количество группу {listBoxGroupForSUZsPF.Items.Count}";*/
        }

        /// <summary>
        /// Метод для записи в ComboBox список всех групп
        /// </summary>
        /// <param name="comboBox"></param>
        public void UploadAllGroups(System.Windows.Forms.ComboBox comboBox)
        {
            Array.Sort(_Variables.ListAllGroups.ToArray());
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
            //AddGroupInList(listBoxListGroupForEmployees, comboBoxListGroupForEmployees, label4);
            //comboBoxListGroupForEmployees.Text = string.Empty;
        }

        private void buttonAddGroupToListGroupForStudent_Click(object sender, EventArgs e)
        {
            //AddGroupInList(listBoxListGroupForStudent, comboBoxListGroupForStudent, label5);
            //comboBoxListGroupForStudent.Text = string.Empty;
        }




        private void buttonAddToListGroupForSUZsPF_Click(object sender, EventArgs e)
        {

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_Actions.GetGroups();
            switch (comboBox1.Text)
            {
                case "Сотрудник":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для Сотрудников";
                    uploadListGroup(_Variables._ListGroupForAddEmployeer, listBox1, "ListGroupForEmplyees");
                    typePost = "ListGroupForEmplyees";
                    groups = _Variables._ListGroupForAddEmployeer;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    break;

                case "Студент":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для Студентов";
                    uploadListGroup(_Variables._ListGroupForAddStudent, listBox1, "ListGroupForStudent");
                    typePost = "ListGroupForStudent";
                    groups = _Variables._ListGroupForAddStudent;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    break;

                case "Произвольный":
                    listBox1.Items.Clear();
                    label9.Text = "Произвольный список групп";
                    uploadListGroup(_Variables._ListGroupForAddArbitrary, listBox1, "Произвольный");
                    typePost = "Произвольный";
                    groups = _Variables._ListGroupForAddArbitrary;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    break;

                case "СУЗсПФ":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для пользователей которые будут созданы с помощью файла";
                    uploadListGroup(_Variables._ListGroupForAddSUZsPF, listBox1, "СУЗсПФ");
                    typePost = "СУЗсПФ";
                    groups = _Variables._ListGroupForAddSUZsPF;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    break;
            }

            /*            if (comboBox1.Text == "Сотрудник")
                        {
                            label9.Text = "Список групп для Сотрудников";
                            uploadListGroup(_Variables._ListGroupForAddEmployeer, listBox1, "ListGroupForEmplyees");
                            UploadAllGroups(comboBox2);
                        }*/

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                // Удаляем позицию из ListBox
                listBox1.Items.RemoveAt(selectedIndex);
            }
            label10.Text = $"Количество группу {listBox1.Items.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupInList(comboBox2.Text, comboBox1.Text);//listBox1, comboBox2, label10);
            comboBox2.Text = string.Empty;
            //comboBoxListGroupForEmployees.Text = string.Empty;
        }

        /// <summary>
        /// метод для добавления группы в список групп по умолчанию 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="comboBox"></param>
        /// <param name="label"></param>
        public void AddGroupInList(string groupWhichNeedAdd, string whichTypePost)//ListBox listBox, System.Windows.Forms.ComboBox comboBox, Label label)
        {
            switch (whichTypePost)
            {
                case "Сотрудник":
                    _Variables._ListGroupForAddEmployeer.Add(groupWhichNeedAdd);
                    listBox1.Items.Add(groupWhichNeedAdd);
                    label10.Text = $"Количество групп: {listBox1.Items.Count}";
                    break;

                case "Студент":
                    _Variables._ListGroupForAddStudent.Add(groupWhichNeedAdd);
                    listBox1.Items.Add(groupWhichNeedAdd);
                    label10.Text = $"Количество групп: {listBox1.Items.Count}";
                    break;

                case "Произвольный":
                    _Variables._ListGroupForAddArbitrary.Add(groupWhichNeedAdd);
                    listBox1.Items.Add(groupWhichNeedAdd);
                    label10.Text = $"Количество групп: {listBox1.Items.Count}";
                    break;

                default:
                    break;
            }


            /* if(typePost=="Сотрудник")
             {
                 _Variables._ListGroupForAddEmployeer.Add(groupWhichNeedAdd);
                 listBox1.Items.Add(groupWhichNeedAdd);
                 label10.Text = $"Количество групп: {listBox1.Items.Count}";
             }
             */



            /*string[] allGroups = new string[listBox.Items.Count];

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
            }*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        /*private void listBoxListGroupForEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           int selectedIndex = listBoxListGroupForEmployees.SelectedIndex;

           // Проверяем, что позиция была выбрана и двойной щелчок выполнен
           if (selectedIndex != -1 && e.Button == MouseButtons.Left)
           {
               // Удаляем позицию из ListBox
               listBoxListGroupForEmployees.Items.RemoveAt(selectedIndex);
           }
           label4.Text = $"Количество группу {listBoxListGroupForEmployees.Items.Count}";
       }

       private void listBoxListGroupForStudent_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           int selectedIndex = listBoxListGroupForStudent.SelectedIndex;

           // Проверяем, что позиция была выбрана и двойной щелчок выполнен
           if (selectedIndex != -1 && e.Button == MouseButtons.Left)
           {
               // Удаляем позицию из ListBox
               listBoxListGroupForStudent.Items.RemoveAt(selectedIndex);
           }
           label5.Text = $"Количество группу {listBoxListGroupForStudent.Items.Count}";
       }

       private void listBoxGroupForSUZsPF_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void listBoxGroupForSUZsPF_MouseDoubleClick(object sender, MouseEventArgs e)
       {

       }
*/

    }
}
