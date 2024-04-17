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
    public partial class MoveMoreUsers : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public MoveMoreUsers()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonAddUserToList_Click(object sender, EventArgs e)
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

        private void MoveMoreUsers_Load(object sender, EventArgs e)
        {
            string[] namesOU = _Actions.ListOU(Domain.GetComputerDomain().ToString()).ToArray();
            Array.Sort(namesOU);
            // Заполнение ComboBox вариантами
            comboBoxListOU.Items.AddRange(namesOU);
            comboBoxFromOU.Items.AddRange(namesOU);

            // Настройка автодополнения
            comboBoxListOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxFromOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFromOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollectionListOu = new AutoCompleteStringCollection();
            autoCompleteCollectionListOu.AddRange(namesOU);

            // Установка источника автодополнения ComboBox
            comboBoxListOU.AutoCompleteCustomSource = autoCompleteCollectionListOu;
            comboBoxFromOU.AutoCompleteCustomSource = autoCompleteCollectionListOu;
        }

        private void MoveMoreUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldOU = _Variables.OU;
            _Variables.OU = comboBoxFromOU.Text;

            foreach (var listUser in listBoxChoosedUser.Items)
            {
                if (string.IsNullOrEmpty(listUser.ToString()))
                {
                    MessageBox.Show("Пустое поле");
                }
                else
                {
                    if (checkBoxLock.Checked)
                    {
                        _Actions.LockUnlockUser(listUser.ToString(), "lock");
                    }
                    else if (checkBoxUnlock.Checked) 
                    {
                        _Actions.LockUnlockUser(listUser.ToString(), "unlock");
                    }

                    _Actions.MoveUsersToOU(listUser.ToString(), comboBoxFromOU.Text, comboBoxListOU.Text);
                }
            }
            _Variables.OU = oldOU;
            this.Close();
        }

        private void comboBoxFromOU_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxListUser.Items.Clear();
            _Actions.GetAllUser(comboBoxFromOU.Text);

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

        private void checkBoxUnlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnlock.Checked)
            {
                checkBoxLock.Checked = false;
            }
        }

        private void checkBoxLock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLock.Checked)
            {
                checkBoxUnlock.Checked = false;
            }
        }
    }
}
