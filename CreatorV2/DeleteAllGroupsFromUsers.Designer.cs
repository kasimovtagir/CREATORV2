namespace CreatorV2
{
    partial class DeleteAllGroupsFromUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxUserName = new ComboBox();
            listBoxAllGroupsFromUsers = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(340, 358);
            button1.Name = "button1";
            button1.Size = new Size(420, 56);
            button1.TabIndex = 0;
            button1.Text = "Удалить ВСЕ группы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 1;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(322, 32);
            label2.TabIndex = 2;
            label2.Text = "Список групп пользователя";
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(237, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(523, 39);
            comboBoxUserName.TabIndex = 3;
            comboBoxUserName.SelectedIndexChanged += comboBoxUserName_SelectedIndexChanged;
            // 
            // listBoxAllGroupsFromUsers
            // 
            listBoxAllGroupsFromUsers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxAllGroupsFromUsers.FormattingEnabled = true;
            listBoxAllGroupsFromUsers.ItemHeight = 31;
            listBoxAllGroupsFromUsers.Location = new Point(340, 69);
            listBoxAllGroupsFromUsers.Name = "listBoxAllGroupsFromUsers";
            listBoxAllGroupsFromUsers.Size = new Size(420, 283);
            listBoxAllGroupsFromUsers.TabIndex = 4;
            // 
            // DeleteAllGroupsFromUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 429);
            Controls.Add(listBoxAllGroupsFromUsers);
            Controls.Add(comboBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "DeleteAllGroupsFromUsers";
            Text = "DeleteAllGroupsFromUsers";
            FormClosing += DeleteAllGroupsFromUsers_FormClosing;
            Load += DeleteAllGroupsFromUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxUserName;
        private ListBox listBoxAllGroupsFromUsers;
    }
}