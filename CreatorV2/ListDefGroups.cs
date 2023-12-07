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
    public partial class ListDefGroups : Form
    {
        public Classes.Variables _Variables;
        public Classes.Actions _Actions;

        public string typePost;
        public List<string> groups = new List<string>();

        public ListDefGroups()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void ListDefGropus_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();
            UploadAllGroups(comboBox2);
        }
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

        private void buttonSaveSettingsListGroup_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Сотрудник":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для Сотрудников";
                    //uploadListGroup(_Variables._ListGroupForAddEmployeer, listBox1, "ListGroupForEmplyees");
                    typePost = "ListGroupForEmplyees";
                    uploadListGroupFromSettingsFile(typePost);
                    groups = _Variables._ListGroupForAddEmployeer;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    button1.Text += " для Сотрудников";
                    break;

                case "Студент":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для Студентов";
                    //uploadListGroup(_Variables._ListGroupForAddStudent, listBox1, "ListGroupForStudent");
                    typePost = "ListGroupForStudent";
                    uploadListGroupFromSettingsFile(typePost);
                    groups = _Variables._ListGroupForAddStudent;
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    button1.Text += " для Студентов";
                    break;

                case "Произвольный":
                    listBox1.Items.Clear();
                    label9.Text = "Произвольный список групп";
                    //uploadListGroup(_Variables._ListGroupForAddArbitrary, listBox1, "Произвольный");
                    typePost = "Произвольный";
                    groups = _Variables._ListGroupForAddArbitrary;
                    uploadListGroup(typePost);
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    button1.Text = "Добавить группу в произвольный список";
                    break;

                case "СУЗсПФ":
                    listBox1.Items.Clear();
                    label9.Text = "Список групп для пользователей которые будут созданы с помощью файла";
                    //uploadListGroup(_Variables._ListGroupForAddSUZsPF, listBox1, "СУЗсПФ");
                    typePost = "СУЗсПФ";
                    groups = _Variables._ListGroupForAddSUZsPF;
                    uploadListGroup(typePost);
                    label10.Text = $"Количество групп: " + listBox1.Items.Count.ToString();
                    button1.Text = "Добавить группу в СУЗсПФ";
                    break;
            }
        }

        public void uploadListGroup(string whatneed)
        {
            if (whatneed == "Произвольный")
            {
                foreach (var item in _Variables._ListGroupForAddArbitrary)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in _Variables._ListGroupForAddSUZsPF)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        public void uploadListGroupFromSettingsFile(string whatneed)
        {
            string[] listGroup = _Actions.LoadSettings2(whatneed).Split(";");

            Array.Sort(listGroup);
            foreach (var item in listGroup)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    listBox1.Items.Add(item.Trim());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {
                addGroupInListWhichUsed();
            }
        }

        public void addGroupInListWhichUsed()
        {
            switch (comboBox1.Text)
            {
                case "Сотрудник":
                    if (checkGroups(_Variables._ListGroupForAddEmployeer, comboBox2.Text))
                    {
                        _Variables._ListGroupForAddEmployeer.Add(comboBox2.Text);
                        listBox1.Items.Add(comboBox2.Text);
                        string listGroupForEmp = string.Empty;
                        foreach (var item in listBox1.Items)
                        {
                            if (!string.IsNullOrEmpty(item.ToString()))
                            {
                                listGroupForEmp += item + ";";
                            }
                        }
                        _Actions.SaveSettingsV2(typePost, listGroupForEmp);
                    }
                    comboBox2.Text = string.Empty;
                    break;

                case "Студент":
                    if (checkGroups(_Variables._ListGroupForAddStudent, comboBox2.Text))
                    {
                        _Variables._ListGroupForAddStudent.Add(comboBox2.Text);
                        listBox1.Items.Add(comboBox2.Text);
                        string listGroupForStud = string.Empty;
                        foreach (var item in listBox1.Items)
                        {
                            if (!string.IsNullOrEmpty(item.ToString()))
                            {
                                listGroupForStud += item + ";";
                            }
                        }
                        _Actions.SaveSettingsV2(typePost, listGroupForStud);
                    }
                    comboBox2.Text = string.Empty;
                    break;

                case "Произвольный":
                    if (checkGroups(_Variables._ListGroupForAddArbitrary, comboBox2.Text))
                    {
                        _Variables._ListGroupForAddArbitrary.Add(comboBox2.Text);
                        listBox1.Items.Add(comboBox2.Text);
                    }
                    comboBox2.Text = string.Empty;
                    break;

                case "СУЗсПФ":
                    if (checkGroups(_Variables._ListGroupForAddSUZsPF, comboBox2.Text))
                    {
                        _Variables._ListGroupForAddSUZsPF.Add(comboBox2.Text);
                        listBox1.Items.Add(comboBox2.Text);
                    }
                    comboBox2.Text = string.Empty;
                    break;

                default:
                    break;
            }
        }

        //метод который проверяет, есть ли эта группа в списке
        public bool checkGroups(List<string> listGroup, string newGroup)
        {
            if (listGroup.Count == 0)
            {
                return true;
            }
            foreach (var item in listGroup)
            {
                if (newGroup == item.Trim())
                {
                    MessageBox.Show("Группа существует. Выбери другую группу");
                    return false;
                }
                //else return ;
            }
            return true;
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

            switch (comboBox1.Text)
            {
                case "Сотрудник":
                    _Variables._ListGroupForAddEmployeer.Clear();
                    string listGroupEmp = string.Empty;
                    foreach (var item in listBox1.Items)
                    {
                        listGroupEmp += item.ToString() + ";";
                    }
                    _Actions.SaveSettingsV2(typePost, listGroupEmp);
                    break;

                case "Студент":
                    _Variables._ListGroupForAddStudent.Clear();
                    string listGroupStud = string.Empty;
                    foreach (var item in listBox1.Items)
                    {
                        listGroupStud += item.ToString() + ";";
                    }
                    _Actions.SaveSettingsV2(typePost, listGroupStud);
                    break;

                case "Произвольный":
                    _Variables._ListGroupForAddArbitrary.Clear();
                    string listGroupArb = string.Empty;
                    foreach (var item in listBox1.Items)
                    {
                        _Variables._ListGroupForAddArbitrary.Add(item.ToString());
                        //listGroupArb += item.ToString() + ";";
                    }
                    //_Variables._ListGroupForAddArbitrary.Add(listGroupArb);
                    break;

                case "СУЗсПФ":
                    _Variables._ListGroupForAddSUZsPF.Clear();
                    string listGroupSUZ = string.Empty;
                    foreach (var item in listBox1.Items)
                    {
                        _Variables._ListGroupForAddArbitrary.Add(item.ToString());
                        //listGroupSUZ += item.ToString() + ";";
                    }
                    //_Variables._ListGroupForAddArbitrary.Add(listGroupSUZ);
                    break;

                default:
                    break;
            }

            //_Actions.SaveSettingsV2(typePost, listGroupForEmp);
            label10.Text = $"Количество группу {listBox1.Items.Count}";
        }
    }
}
