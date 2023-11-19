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
    public partial class SetExpirationDate : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public SetExpirationDate()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonSaveExpirateDate_Click(object sender, EventArgs e)
        {
            //string username = "имя_пользователя"; // Замените на имя пользователя, которого вы хотите заблокировать
            //DateTime lockoutDate = dateTimePickerExpirationDate.Value.ToString("dd.MM.yyyy");
            string formattedDate = dateTimePickerExpirationDate.Value.ToString("dd.MM.yyyy 12:01");

            _Actions.SetExpirateDate(comboBoxUserName.Text, formattedDate);
            this.Close();

        }

        private void SetExpirationDate_Load(object sender, EventArgs e)
        {
            _Actions.GetAllUser();
            string[] names = _Variables.AllUsersInAD.ToArray();

            Array.Sort(names);
            // Заполнение ComboBox вариантами
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
    }
}
