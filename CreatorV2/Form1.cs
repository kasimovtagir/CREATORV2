using CreatorV2.Classes;
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

            _Variables = new Classes.Variables();
            _Actions = new Classes.Actions(_Variables);
        }

        private void àêêàóíòÄëÿÎòïğàâêèEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            accountSettings._Variables = _Variables;
            accountSettings._Actions = _Actions;
            accountSettings.ShowDialog();

        }

        private void äîìåíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainSettings domainSettings = new DomainSettings();

            domainSettings.ShowDialog();
        }

        private void òåêñòÏèñüìàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMessageRUS textMessageRUS = new TextMessageRUS();
            textMessageRUS._Variables = _Variables;
            textMessageRUS._Actions = _Actions;
            textMessageRUS.ShowDialog();
        }
    }
}