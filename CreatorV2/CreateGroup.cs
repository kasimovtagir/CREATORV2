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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CreatorV2
{
    public partial class CreateGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public CreateGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }
        private void CreateGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray();

            Array.Sort(names);
            // Заполнение ComboBox вариантами
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

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            if (_Actions.DoesADGroupExist(textBoxNameGroup.Text.Trim()))
            {
                MessageBox.Show("Группа с таким названием уже существует.");
            }
            else
            {
                _Actions.CreateGroup(textBoxNameGroup.Text.Trim(), textBoxDescription.Text.Trim());

                if (listBoxChoosedUser.Items.Count != 0)
                {
                    foreach (var choosedUser in listBoxChoosedUser.Items)
                    {
                        string username = _Actions.GetSamAccountNameByDisplayName(choosedUser.ToString());
                        _Actions.AddUserToGroup(username, textBoxNameGroup.Text.Trim());
                    }
                }
            }
            this.Close();
        }

        private void buttonAddChoosedUser_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь в comboBoxListUser
            if (string.IsNullOrEmpty(comboBoxListUser.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxChoosedUser.Items.Contains(comboBoxListUser.Text))
                {
                    listBoxChoosedUser.Items.Add(comboBoxListUser.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListUser.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void listBoxChoosedUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxChoosedUser.SelectedIndex;
            string choosed = string.Empty;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                choosed = listBoxChoosedUser.Items[selectedIndex].ToString().Trim();
                // Удаляем позицию из ListBox
                listBoxChoosedUser.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
