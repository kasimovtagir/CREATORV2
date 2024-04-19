/*using CreatorV2.Classes;
using static System.Windows.Forms.DataFormats;*/

using CreatorV2.Classes;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace CreatorV2
{
    public partial class Form1 : Form
    {
        public Classes.Variables _Variables;// { get; set; }
        public Classes.Actions _Actions;//{ get; set; }
        public Form1()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
            MainSettings newMainSett = new MainSettings();
            newMainSett._Variables = _Variables;
            newMainSett._Actions = _Actions;

            if (!File.Exists("Settings.txt"))
            {
                MessageBox.Show("” вас нет конфигурационного файла, сейчас откроетс€ окно в котором необходимо заполнить все пол€ дл€ корректной работы программы! —пасибо");

                using (FileStream fs = File.Create("Settings.txt"))
                {
                    //File.Create
                }
                newMainSett.ShowDialog();
            }
            else
            {
                using (StreamReader reader = new StreamReader("Settings.txt"))
                {
                    string settings = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(settings))
                    {
                        newMainSett.ShowDialog();
                    }
                    else
                    {
                        _Actions.UploadAllSettings();
                    }
                }
            }
        }




        /// <summary>
        /// метод дл€ теста
        /// </summary>
        public void ForTest()
        {
            textBoxUserNameInAD.Text = "NameForAD";
            textBoxLastNameInAD.Text = "LastNameForAD";
            textBoxLastName.Text = "LastNameRUS";
            textBoxName.Text = "NameRUS";
            textBoxThirdName.Text = "thirNameRUS";
            textBoxISUID.Text = "ISUID";
            textBoxDescription.Text = "тестовый пользователь";
            textBoxEMAIL.Text = "tagir.kasimov@metalab.ifmo.ru";
            textBoxPassword.Text = _Variables._PasswordInAD;
            comboBoxTypePost.Text = "—отрудник";
        }

        private void аккаунтƒл€ќтправкиEmailToolStripMenuItem_Click(object sender, EventArgs e)
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
            showLog();
        }



        private void группыѕо”молчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDefGroups listGroup = new ListDefGroups();
            listGroup._Variables = _Variables;
            listGroup._Actions = _Actions;

            listGroup.ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // ѕровер€ем, что поле имени и фамилии содержит только русские буквы
            bool checkRUStxtboxName = Regex.IsMatch(textBoxUserNameInAD.Text.Trim(), "^[ј-яа-€]+$");
            bool checkRUStxtboxSurName = Regex.IsMatch(textBoxLastNameInAD.Text.Trim(), "^[ј-яа-€]+$");

            // ѕолучаем и обрабатываем им€ и фамилию
            string name = textBoxUserNameInAD.Text.Trim();
            string lastName = textBoxLastNameInAD.Text.Trim();

            _Variables._WithEmail = true;

            if (checkRUStxtboxName | checkRUStxtboxSurName)
            {
                name = _Actions.Transliteration(name);
                lastName = _Actions.Transliteration(lastName);
                var textInfo = new CultureInfo("ru-RU").TextInfo;
                //преобразуем текст
                name = textInfo.ToTitleCase(textInfo.ToLower(name));
                lastName = textInfo.ToTitleCase(textInfo.ToLower(lastName));
                _Variables._nameInAD = name;
                _Variables._lastNameInAD = lastName;
            }
            else
            {
                _Variables._nameInAD = name;
                _Variables._lastNameInAD = lastName;
            }

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


            if (checkBoxWinthEmail.Checked)
            {
                PreviewCreateUsersAccountWithSendEmail newUser = new PreviewCreateUsersAccountWithSendEmail();
                newUser._Variables = _Variables;
                newUser._Actions = _Actions;
                newUser.ShowDialog();
            }
            else
            {
                PreviewCreateUsersAccountWithoutSendEmail newUserWinthoutSendEmail = new PreviewCreateUsersAccountWithoutSendEmail();
                newUserWinthoutSendEmail._Variables = _Variables;
                newUserWinthoutSendEmail._Actions = _Actions;
                newUserWinthoutSendEmail.ShowDialog();
            }

            showLog();
            clearForm();
        }

        public void clearForm()
        {
            textBoxUserNameInAD.Text = string.Empty;
            textBoxLastNameInAD.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxThirdName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxISUID.Text = string.Empty;
            textBoxEMAIL.Text = string.Empty;
            comboBoxTypePost.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPassword.Text = _Variables._PasswordInAD;
            //ForTest(); // метод дл€ тестировани€ 
        }

        private void одинаныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserInGroup addUserInGroup = new AddUserInGroup();
            addUserInGroup._Variables = _Variables;
            addUserInGroup._Actions = _Actions;
            addUserInGroup.ShowDialog();
            showLog();
        }
        private void установитьѕарольѕользовател€ѕо”молчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefPasswordForUser defPasswordForUser = new DefPasswordForUser();
            defPasswordForUser._Variables = _Variables;
            defPasswordForUser._Actions = _Actions;
            defPasswordForUser.ShowDialog();
            showLog();
        }

        private void парольƒл€ѕользовател€ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForUser changePasswordForUser = new ChangePasswordForUser();
            changePasswordForUser._Variables = _Variables;
            changePasswordForUser._Actions = _Actions;
            changePasswordForUser.ShowDialog();
            showLog();
        }

        public void showLog()
        {
            listBoxAllLog.Items.Clear();
            if (_Variables.Log != null)
            {
                foreach (var item in _Variables.Log)
                {
                    listBoxAllLog.Items.Add(item);
                }
            }

        }

        private void создать¬ременную√руппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTempGroups createTempGroups = new CreateTempGroups();
            createTempGroups._Variables = _Variables;
            createTempGroups._Actions = _Actions;
            createTempGroups.ShowDialog();
            showLog();
        }

        private void создать√руппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGroup createGroup = new CreateGroup();
            createGroup._Actions = _Actions;
            createGroup._Variables = _Variables;
            createGroup.ShowDialog();
            showLog();
        }

        private void конкретнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadListUsersFromGroup uploadListUsersFromGroup = new UploadListUsersFromGroup();
            uploadListUsersFromGroup._Variables = _Variables;
            uploadListUsersFromGroup._Actions = _Actions;
            uploadListUsersFromGroup.ShowDialog();
            showLog();
        }

        private void вс®ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UploadListUserFromAllGroup upload = new UploadListUserFromAllGroup();
            upload._Variables = _Variables;
            upload._Actions = _Actions;
            upload.ShowDialog();
            showLog();
        }

        private void текстѕисьмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMessage textMessage = new TextMessage();
            textMessage._Variables = _Variables;
            textMessage._Actions = _Actions;
            textMessage.ShowDialog();
            showLog();
        }

        private void включить“естовый–ежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLastNameInAD.Text == "")
            {
                ForTest();
                включить“естовый–ежимToolStripMenuItem.Text = "¬ыключить тестовый режим";
            }
            else
            {
                clearForm();
                включить“естовый–ежимToolStripMenuItem.Text = "¬ключить тестовый режим";
            }
        }

        private void одинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserFromGroup deleteUserFromGroup = new DeleteUserFromGroup();
            deleteUserFromGroup._Variables = _Variables;
            deleteUserFromGroup._Actions = _Actions;
            deleteUserFromGroup.ShowDialog();
            showLog();
        }

        private void пользователей¬√руппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoreUsersInGroup addMoreUsersInGroup = new AddMoreUsersInGroup();
            addMoreUsersInGroup._Variables = _Variables;
            addMoreUsersInGroup._Actions = _Actions;
            addMoreUsersInGroup.ShowDialog();
            showLog();
        }

        private void группѕользователюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoreGroupsToUser addMoreGroupsToUser = new AddMoreGroupsToUser();
            addMoreGroupsToUser._Variables = _Variables;
            addMoreGroupsToUser._Actions = _Actions;
            addMoreGroupsToUser.ShowDialog();
            showLog();
        }

        private void несколькоѕользователе¬Ќесколько√руппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoreUsersToMoreGroups addMoreUsersToMoreGroups = new AddMoreUsersToMoreGroups();
            addMoreUsersToMoreGroups._Variables = _Variables;
            addMoreUsersToMoreGroups._Actions = _Actions;
            addMoreUsersToMoreGroups.ShowDialog();
            showLog();
        }

        private void несколькоѕользователей»з√руппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMoreUsersFromGroup delete = new DeleteMoreUsersFromGroup();
            delete._Variables = _Variables;
            delete._Actions = _Actions;
            delete.ShowDialog();
            showLog();
        }

        private void несколько√рупп”ѕользовател€ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMoreGroupsFromUsers deleteMoreGroupsFromUsers = new DeleteMoreGroupsFromUsers();
            deleteMoreGroupsFromUsers._Variables = _Variables;
            deleteMoreGroupsFromUsers._Actions = _Actions;
            deleteMoreGroupsFromUsers.ShowDialog();
            showLog();
        }

        private void одинарныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnlockLockUser unlockLockUser = new UnlockLockUser();
            unlockLockUser._Variables = _Variables;
            unlockLockUser._Actions = _Actions;
            unlockLockUser.ShowDialog();
            showLog();
        }

        private void множественныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UnlockLockMoreUsers unlock = new UnlockLockMoreUsers();
            unlock._Variables = _Variables;
            unlock._Actions = _Actions;
            unlock.ShowDialog(); showLog();
        }

        private void одинарныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteAllGroupsFromUsers deleteAllGroupsFromUsers = new DeleteAllGroupsFromUsers();
            deleteAllGroupsFromUsers._Variables = _Variables;
            deleteAllGroupsFromUsers._Actions = _Actions;
            deleteAllGroupsFromUsers.ShowDialog(); showLog();
        }

        private void множественныйToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteAllGroupsFromMoreUsers deleteAllGroupsFromMoreUsers = new DeleteAllGroupsFromMoreUsers();
            deleteAllGroupsFromMoreUsers._Variables = _Variables;
            deleteAllGroupsFromMoreUsers._Actions = _Actions;
            deleteAllGroupsFromMoreUsers.ShowDialog(); showLog();
        }

        private void множественныйToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MoveMoreUsers moveMoreUsers = new MoveMoreUsers();
            moveMoreUsers._Variables = _Variables;
            moveMoreUsers._Actions = _Actions;
            moveMoreUsers.ShowDialog(); showLog();
        }

        private void одинарныйToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MoveUsers moveUsers = new MoveUsers();
            moveUsers._Variables = _Variables;
            moveUsers._Actions = _Actions;
            moveUsers.ShowDialog(); showLog();
        }

        private void одинарныйToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetExpirationDate setExpirationDate = new SetExpirationDate();
            setExpirationDate._Variables = _Variables;
            setExpirationDate._Actions = _Actions;
            setExpirationDate.ShowDialog();
            showLog();
        }

        private void множественныйToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SetExpirationDateMoreUsers setExpirationDateMoreUsers = new SetExpirationDateMoreUsers();
            setExpirationDateMoreUsers._Variables = _Variables;
            setExpirationDateMoreUsers._Actions = _Actions;
            setExpirationDateMoreUsers.ShowDialog();
            showLog();
        }

        private void удалить√руппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup deleteGroup = new DeleteGroup();
            deleteGroup._Variables = _Variables;
            deleteGroup._Actions = _Actions;
            deleteGroup.ShowDialog();
            showLog();
        }

        private void карточка—отрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeCard employeeCard = new EmployeeCard();
            employeeCard._Variables = _Variables;
            employeeCard._Actions = _Actions;
            employeeCard.ShowDialog();
            
        }
    }
}