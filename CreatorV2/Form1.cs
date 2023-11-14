/*using CreatorV2.Classes;
using static System.Windows.Forms.DataFormats;*/

using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CreatorV2
{
    public partial class Form1 : Form
    {
        public Classes.Variables _Variables;// { get; set; }
        public Classes.Actions _Actions;//{ get; set; }
        public Form1()
        {
            InitializeComponent();

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);

            _Actions.GetSettings();
            ForTest();

            _Actions.UploadAllSettings();
        }




        /// <summary>
        /// метод для теста
        /// </summary>
        public void ForTest()
        {
            textBoxUserNameInAD.Text = "NameForAD";
            textBoxLastNameInAD.Text = "LastNameForAD";
            textBoxLastName.Text = "LastNameRUS";
            textBoxName.Text = "NameRUS";
            textBoxThirdName.Text = "thirNameRUS";
            textBoxISUID.Text = "ISUID";
            textBoxDescription.Text = "";
            textBoxEMAIL.Text = "tagir.kasimov@metalab.ifmo.ru";
            textBoxPassword.Text = _Variables._PasswordInAD;
            comboBoxTypePost.Text = "Сотрудник";
        }

        private void аккаунтДляОтправкиEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            accountSettings._Variables = _Variables;
            accountSettings._Actions = _Actions;
            accountSettings.ShowDialog();

        }

        private void доменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainSettings domainSettings = new DomainSettings();
            domainSettings._Variables = _Variables;
            domainSettings._Actions = _Actions;
            domainSettings.ShowDialog();
        }

        private void текстПисьмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMessageRUS textMessageRUS = new TextMessageRUS();
            textMessageRUS._Variables = _Variables;
            textMessageRUS._Actions = _Actions;
            textMessageRUS.ShowDialog();
        }

        private void группыПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListGroup listGroup = new ListGroup();
            listGroup._Variables = _Variables;
            listGroup._Actions = _Actions;
            //_Actions.GetSettings();
            listGroup.ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // Проверяем, что поле имени и фамилии содержит только русские буквы
            bool checkRUStxtboxName = Regex.IsMatch(textBoxUserNameInAD.Text, "^[А-Яа-я]+$");
            bool checkRUStxtboxSurName = Regex.IsMatch(textBoxLastNameInAD.Text, "^[А-Яа-я]+$");

            // Получаем и обрабатываем имя и фамилию
            string name = textBoxUserNameInAD.Text.Trim();
            string lastName = textBoxLastNameInAD.Text.Trim();

            _Variables._WithEmail = true;

            if (checkRUStxtboxName)
            {
                name = _Actions.Transliteration(name);
            }

            if (checkRUStxtboxSurName)
            {
                lastName = _Actions.Transliteration(lastName);
            }

            // Устанавливаем имя и фамилию
            _Variables._nameInAD = name;
            _Variables._lastNameInAD = lastName;
            if (name.Length + lastName.Length > 17)
            {
                _Variables._SamAccountInAD = $"{name[0]}.{lastName}";
            }
            else _Variables._SamAccountInAD = $"{name}.{lastName}";
            _Variables._UserlastName = textBoxName.Text.Trim();
            _Variables._UserName = textBoxLastName.Text.Trim();
            _Variables._UserThistName = textBoxThirdName.Text.Trim();
            _Variables._UserISU_ID = textBoxISUID.Text.Trim();
            _Variables._UserDescription = textBoxDescription.Text.Trim();
            _Variables._UsersEmail = textBoxEMAIL.Text.Trim();
            _Variables._PasswordInAD = textBoxPassword.Text.Trim();
            _Variables._TypePost = comboBoxTypePost.Text;

            PreviewCreateUsersAccountWithSendEmail newUser = new PreviewCreateUsersAccountWithSendEmail();
            newUser._Variables = _Variables;
            newUser._Actions = _Actions;
            newUser.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void парольДляПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DefPasswordForUser defPasswordForUser = new DefPasswordForUser();
            defPasswordForUser._Variables = _Variables;
            defPasswordForUser._Actions = _Actions;
            defPasswordForUser.ShowDialog();
            foreach (var item in _Variables.Log)
            {
                listBox1.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void добавитьПользователяВГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void одинаныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserInGroup addUserInGroup = new AddUserInGroup();
            addUserInGroup._Variables = _Variables;
            addUserInGroup._Actions = _Actions;
            addUserInGroup.ShowDialog();
        }
    }
}