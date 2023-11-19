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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatorV2
{
    public partial class UploadListUserFromAllGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public UploadListUserFromAllGroup()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void UploadListUserFromAllGroup_Load(object sender, EventArgs e)
        {
            
        }

        private void UploadListUserFromAllGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Variables.AllUsersInAD.Clear();
            _Variables.ListAllGroups.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"listAllGroupsAndUsers.txt";
            _Actions.GetGroups();
            // Инициализация ProgressBar
            progressBar.Minimum = 0;
            progressBar.Maximum = _Variables.ListAllGroups.Count ;
            progressBar.Value = 0;
            int progressValue = 0;
            List<string> results = new List<string>();

            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {                    
                    foreach (var item in _Variables.ListAllGroups)//formData.AllGroupsInAD)
                    {
                        results = _Actions.showUsersInGroup(item);
                        
                        sw.WriteLine(item);
                        //int progressValue = 0;
                        foreach (var items in results)
                        {
                            sw.WriteLine($"\t{items}");
                        }
                        progressValue++;
                        label1.Text = string.Empty;
                        label1.Text = $"{item} выгрежен.";
                        progressBar.Value = progressValue;
                    }
                    label1.Text = "ГОТОВО, ВСЕ ВЫГРУЖЕНО.";
                }
                catch (Exception ex) { MessageBox.Show($"error {ex}"); }
            }
            _Variables.Log.Add("Готово. Вся информация выгружена в файл listAllGroupsAndUsers.txt");
            this.Close();
        }
    }
}
