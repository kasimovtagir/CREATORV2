using CreatorV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class SUZsPF : Form
    {
        Actions _Actions;
        Variables _Variables;
        string FileName { get; set; }
        Dictionary<string, string> AllUsers = new Dictionary<string, string>();
        public List<UserAccounts> _Users { get; set; }


        private List<UserAccounts> GetUsersList()
        {
            var listUser = new List<UserAccounts>();

            int i = 0;
            string text = System.IO.File.ReadAllText(FileName);
            foreach (var item in System.IO.File.ReadAllLines(FileName))
            {
                string[] sepName = item.ToString().Split(' ');

                string name = _Actions.Transliteration(sepName[1].ToString());
                string lastname = _Actions.Transliteration(sepName[0].ToString());
                string samaccountname = $"{name.ToLower()}.{lastname.ToLower()}";
                if (samaccountname.Length > 17)
                {
                    samaccountname = $"{name[0].ToString().ToLower()}.{lastname.ToLower()}";
                }

                name = char.ToUpper(name[0]) + name.Substring(1);
                lastname = char.ToUpper(lastname[0]) + lastname.Substring(1);


                listUser.Add(new UserAccounts()
                {
                    UserAccountID = i++,
                    LastName = lastname,
                    UserName = name,
                    SamAccountName = samaccountname,
                    Password = _Variables._PasswordInAD
                });
                AllUsers.Add($"{name} {lastname}", samaccountname);
            }

            return listUser;
        }


        public SUZsPF(Actions actions, Variables variables)
        {
            InitializeComponent();
            _Variables = variables;
            _Actions = actions;
            //_Users = GetUsersList();
        }

        private void SUZsPF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            FileName = openFileDialog1.FileName;
            label1.Text = FileName;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.OpenFile();

            _Users = GetUsersList();
            //GetUsersList();

            var listUser = this._Users;
            dataGridView1.DataSource = listUser;

            // dataGridView1.Columns["UserAccountID"].Visible = false;



            // читаем файл в строку
            // string fileText = System.IO.File.ReadAllText(filename);
        }



        public void CreateAndWriteFile(string path, Dictionary<string, string> listUsersWithPass)
        {
            using (FileStream fs = File.Create($"{path}.withPasswords.txt"))
            { }
            try
            {
                // Create the file, or overwrite if the file exists.
                using (StreamWriter sw = new StreamWriter($"{path}.withPasswords.txt"))
                {
                    foreach (var item in listUsersWithPass)
                    {
                        sw.WriteLine($"{item.Value}");
                    }
                    sw.Close();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Variables._TypePost = "Студент";
            foreach (var item in AllUsers)
            {
                string[] nameAndLastName = item.Key.Split(' ');

                _Variables._nameInAD = nameAndLastName[0];
                _Variables._lastNameInAD = nameAndLastName[1];
                _Variables._SamAccountInAD = item.Value;

                _Actions.CreateADAccount();
                _Actions.AddUserToDefGroups();
            }

            CreateAndWriteFile(FileName, AllUsers);
            MessageBox.Show("Учетные записи созданы. Спасибо за использование СУЗсПФ :-) ");
            this.Close();
        }
    }
}
