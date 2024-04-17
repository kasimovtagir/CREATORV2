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
    public partial class SetExpirationDateMoreUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public SetExpirationDateMoreUsers()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void SetExpirationDateMoreUsers_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray();

            Array.Sort(names);
            // Заполнение ComboBox вариантами
            comboBoxListUsers.Items.AddRange(names);

            // Настройка автодополнения
            comboBoxListUsers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListUsers.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(names);

            // Установка источника автодополнения ComboBox
            comboBoxListUsers.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            string choosdUser = comboBoxListUsers.Text.ToString();
            if (string.IsNullOrEmpty(choosdUser))
            {
                MessageBox.Show("Пустое поле. Выбери пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (listBoxChoosedUsers.Items.Contains(comboBoxListUsers.Text))
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }
                else
                {
                    listBoxChoosedUsers.Items.Add(comboBoxListUsers.Text);                    
                }
            }
            comboBoxListUsers.Text = string.Empty;
        }

        private void buttonExpirateDate_Click(object sender, EventArgs e)
        {
            foreach (var choosedUsers in listBoxChoosedUsers.Items)
            {
                if (string.IsNullOrEmpty(choosedUsers.ToString()))
                {
                    MessageBox.Show("Пустое поле");
                    continue;
                }
                else
                {
                    string formattedDate = dateTimePickerExpirationDate.Value.ToString("dd.MM.yyyy 12:01");

                    _Actions.SetExpirateDate(choosedUsers.ToString(), formattedDate);
                }
            }
            this.Close();
        }
    }
}
