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
    public partial class UploadListGroupAtUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public UploadListGroupAtUser()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void UploadListGroupAtUser_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray(); //Data.AllUsersInAD.ToArray();
            Array.Sort(names);
            // Заполнение ComboBox вариантами
            //comboBox1.Items.AddRange(names);
            comboBoxUserName.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxUserName.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void UploadListGroupAtUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь в comboBoxListUser
            if (string.IsNullOrEmpty(comboBoxUserName.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxListUser.Items.Contains(comboBoxUserName.Text))
                {
                    listBoxListUser.Items.Add(comboBoxUserName.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxUserName.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void buttonUploadListUser_Click(object sender, EventArgs e)
        {
            foreach (var itemChoosedUser in listBoxListUser.Items)
            {
                string path = $@"listAllGroupsAt_{itemChoosedUser}.txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    try
                    {
                        ListBox listBoxListGroupAtUser = _Actions.GetListGroupUsers(itemChoosedUser.ToString());
                        sw.WriteLine(itemChoosedUser);
                        foreach (var items in listBoxListGroupAtUser.Items)
                        {
                            sw.WriteLine($"\t{items.ToString().Replace("CN=", "")}");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"error {ex}"); }
                }
                _Variables.Log.Add($"Готово. Вся информация выгружена в файл listAllGroupsAt_{itemChoosedUser}.txt");
            }
            this.Close();
        }
    }
}
