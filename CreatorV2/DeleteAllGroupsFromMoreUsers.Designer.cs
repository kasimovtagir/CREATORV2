namespace CreatorV2
{
    partial class DeleteAllGroupsFromMoreUsers
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
            buttonAddUserToList = new Button();
            comboBoxUserName = new ComboBox();
            button1 = new Button();
            listBoxChoosedUser = new ListBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonAddUserToList
            // 
            buttonAddUserToList.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUserToList.Location = new Point(564, 11);
            buttonAddUserToList.Margin = new Padding(2);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(142, 38);
            buttonAddUserToList.TabIndex = 39;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += buttonAddUserToList_Click;
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(187, 11);
            comboBoxUserName.Margin = new Padding(2);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(361, 37);
            comboBoxUserName.TabIndex = 37;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(188, 380);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(518, 68);
            button1.TabIndex = 36;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.HorizontalScrollbar = true;
            listBoxChoosedUser.ItemHeight = 29;
            listBoxChoosedUser.Location = new Point(191, 53);
            listBoxChoosedUser.Margin = new Padding(2);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.ScrollAlwaysVisible = true;
            listBoxChoosedUser.Size = new Size(519, 323);
            listBoxChoosedUser.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 29);
            label3.TabIndex = 34;
            label3.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 29);
            label2.TabIndex = 33;
            label2.Text = "Выбранные";
            // 
            // DeleteAllGroupsFromMoreUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxUserName);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "DeleteAllGroupsFromMoreUsers";
            Text = "DeleteAllGroupsFromMoreUsers";
            FormClosing += DeleteAllGroupsFromMoreUsers_FormClosing;
            Load += DeleteAllGroupsFromMoreUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUserToList;
        private ComboBox comboBoxUserName;
        private Button button1;
        private ListBox listBoxChoosedUser;
        private Label label3;
        private Label label2;
    }
}