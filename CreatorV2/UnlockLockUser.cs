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
    public partial class UnlockLockUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public UnlockLockUser()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _Actions.LockUnlockUser(comboBoxUserName.Text, "lock");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Actions.LockUnlockUser(comboBoxUserName.Text, "unlock");
            this.Close();
        }

        private void UnlockLockUser_Load(object sender, EventArgs e)
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

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Actions.checkLockOrUnLockUser(comboBoxUserName.Text))
            {
                buttonUnLock.Enabled = false;
                buttonLock.Enabled = true;
            }
            else
            {
                buttonLock.Enabled = false;
                buttonUnLock.Enabled = true;
            }
        }
    }
}
