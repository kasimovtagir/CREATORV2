namespace CreatorV2
{
    partial class AddMoreUsersInGroup
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
            comboBoxListGroup = new ComboBox();
            comboBoxListUser = new ComboBox();
            button1 = new Button();
            listBoxChoosedUser = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAddUserToList
            // 
            buttonAddUserToList.Location = new Point(634, 11);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(130, 47);
            buttonAddUserToList.TabIndex = 15;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += buttonAddUserToList_Click;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(216, 302);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(548, 46);
            comboBoxListGroup.TabIndex = 14;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(216, 12);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(412, 46);
            comboBoxListUser.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(216, 358);
            button1.Name = "button1";
            button1.Size = new Size(548, 85);
            button1.TabIndex = 12;
            button1.Text = "Добавить выбранных пользователей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.HorizontalScrollbar = true;
            listBoxChoosedUser.ItemHeight = 38;
            listBoxChoosedUser.Location = new Point(216, 64);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.ScrollAlwaysVisible = true;
            listBoxChoosedUser.Size = new Size(548, 232);
            listBoxChoosedUser.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 314);
            label3.Name = "label3";
            label3.Size = new Size(106, 38);
            label3.TabIndex = 10;
            label3.Text = "Группа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 9;
            label2.Text = "Выбранные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 8;
            label1.Text = "Пользователь";
            // 
            // AddMoreUsersInGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 456);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMoreUsersInGroup";
            Text = "AddMoreUsersInGroup";
            FormClosed += AddMoreUsersInGroup_FormClosed;
            Load += AddMoreUsersInGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUserToList;
        private ComboBox comboBoxListGroup;
        private ComboBox comboBoxListUser;
        private Button button1;
        private ListBox listBoxChoosedUser;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}