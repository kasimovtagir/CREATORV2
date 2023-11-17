/*using CreatorV2.Classes;
using static System.Windows.Forms.DataFormats;*/

using System.DirectoryServices.ActiveDirectory;
using System.IO;
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

            if (!File.Exists("Settings.txt"))
            {
                MessageBox.Show("� ��� ��� ����������������� �����, ������ ��������� ���� � ������� ���������� ��������� ��� ���� ��� ���������� ������ ���������! �������");
                MainSettings newMainSett = new MainSettings();
                newMainSett._Variables = _Variables;
                newMainSett._Actions = _Actions;

                using (FileStream fs = File.Create("Settings.txt"))
                {
                    //File.Create();                    
                }
                newMainSett.ShowDialog();
            }
            else _Actions.UploadAllSettings();

            //ForTest();
        }




        /// <summary>
        /// ����� ��� �����
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
            comboBoxTypePost.Text = "���������";
        }

        private void ������������������EmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            accountSettings._Variables = _Variables;
            accountSettings._Actions = _Actions;
            accountSettings.ShowDialog();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainSettings domainSettings = new DomainSettings();
            domainSettings._Variables = _Variables;
            domainSettings._Actions = _Actions;
            domainSettings.ShowDialog();
        }



        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListGroup listGroup = new ListGroup();
            listGroup._Variables = _Variables;
            listGroup._Actions = _Actions;

            listGroup.ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // ���������, ��� ���� ����� � ������� �������� ������ ������� �����
            bool checkRUStxtboxName = Regex.IsMatch(textBoxUserNameInAD.Text, "^[�-��-�]+$");
            bool checkRUStxtboxSurName = Regex.IsMatch(textBoxLastNameInAD.Text, "^[�-��-�]+$");

            // �������� � ������������ ��� � �������
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

            // ������������� ��� � �������
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
            //_Actions.GetSettings();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ���������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserInGroup addUserInGroup = new AddUserInGroup();
            addUserInGroup._Variables = _Variables;
            addUserInGroup._Actions = _Actions;
            addUserInGroup.ShowDialog();
        }

        private void �����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextMessage textMessage = new TextMessage();
            textMessage._Variables = _Variables;
            textMessage._Actions = _Actions;
            textMessage.ShowDialog();
        }


        private void ���������������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefPasswordForUser defPasswordForUser = new DefPasswordForUser();
            defPasswordForUser._Variables = _Variables;
            defPasswordForUser._Actions = _Actions;
            defPasswordForUser.ShowDialog();
            showLog();
        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForUser changePasswordForUser = new ChangePasswordForUser();
            changePasswordForUser._Variables = _Variables;
            changePasswordForUser._Actions = _Actions;
            changePasswordForUser.ShowDialog();
            showLog();
        }

        private void ���������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserFromGroup deleteUserFromGroup = new DeleteUserFromGroup();
            deleteUserFromGroup._Variables = _Variables;
            deleteUserFromGroup._Actions = _Actions;
            deleteUserFromGroup.ShowDialog();
            showLog();
        }

        public void showLog()
        {
            listBoxAllLog.Items.Clear();
            foreach (var item in _Variables.Log)
            {
                listBoxAllLog.Items.Add(item);
            }
        }
    }
}