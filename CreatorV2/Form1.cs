/*using CreatorV2.Classes;
using static System.Windows.Forms.DataFormats;*/

using System.Text.RegularExpressions;

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

            //_Actions.GetSettings();
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

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMessageRUS textMessageRUS = new TextMessageRUS();
            textMessageRUS._Variables = _Variables;
            textMessageRUS._Actions = _Actions;
            textMessageRUS.ShowDialog();
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListGroup listGroup = new ListGroup();
            listGroup._Variables = _Variables;
            listGroup._Actions = _Actions;
            _Actions.GetSettings();
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
            _Variables._UserlastName = textBoxName.Text.Trim();
            _Variables._UserName = textBoxLastName.Text.Trim();
            _Variables._UserThistName = textBoxThirdName.Text.Trim();
            _Variables._UserISU_ID = textBoxISUID.Text.Trim();
            _Variables._UserDescription = textBoxDescription.Text.Trim();
            _Variables._UsersEmail = textBoxEMAIL.Text.Trim();
            _Variables._PasswordInAD = textBoxPassword.Text.Trim();
            _Variables._TypePost = comboBoxTypePost.SelectedIndex.ToString();        
        }
    }
}