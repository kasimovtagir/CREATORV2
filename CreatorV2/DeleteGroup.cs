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
    public partial class DeleteGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public DeleteGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void DeleteGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();
            string[] group_names = _Variables.ListAllGroups.ToArray(); // Data.AllGroupsInAD.ToArray();
            Array.Sort(group_names);
            // Заполнение ComboBox вариантами
            comboBoxListGroup.Items.AddRange(group_names);

            // Настройка автодополнения
            comboBoxListGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxListGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollection2 = new AutoCompleteStringCollection();
            autoCompleteCollection2.AddRange(group_names);

            // Установка источника автодополнения ComboBox
            comboBoxListGroup.AutoCompleteCustomSource = autoCompleteCollection2;
        }

        private void DeleteGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Variables.ListAllGroups.Clear();
            _Variables.AllUsersInAD.Clear();
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь в comboBoxListUser
            if (string.IsNullOrEmpty(comboBoxListGroup.Text))
            {
                MessageBox.Show("Выберите пользователя.");
            }
            else
            {
                // Проверяем, содержится ли выбранный пользователь уже в списке
                if (!listBoxListChoosedGroup.Items.Contains(comboBoxListGroup.Text))
                {
                    listBoxListChoosedGroup.Items.Add(comboBoxListGroup.Text);
                }
                else
                {
                    MessageBox.Show("Пользователь уже в списке.");
                }

                comboBoxListGroup.Text = string.Empty; // Очищаем текстовое поле comboBoxListUser
            }
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            foreach (var groupName in listBoxListChoosedGroup.Items)
            {
                if (!string.IsNullOrEmpty(groupName.ToString()))
                {
                    _Actions.DeleteGroup(groupName.ToString());
                }
            }
            
            this.Close();
        }
    }
}
