namespace CreatorV2
{
    partial class DeleteMoreUsersFromGroup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxChoosedUser = new ListBox();
            button1 = new Button();
            comboBoxListUser = new ComboBox();
            comboBoxListGroup = new ComboBox();
            buttonAddUserToList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 0;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 1;
            label2.Text = "Выбранные";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 315);
            label3.Name = "label3";
            label3.Size = new Size(106, 38);
            label3.TabIndex = 2;
            label3.Text = "Группа";
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.HorizontalScrollbar = true;
            listBoxChoosedUser.ItemHeight = 38;
            listBoxChoosedUser.Location = new Point(212, 65);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.ScrollAlwaysVisible = true;
            listBoxChoosedUser.Size = new Size(548, 232);
            listBoxChoosedUser.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(212, 359);
            button1.Name = "button1";
            button1.Size = new Size(548, 85);
            button1.TabIndex = 4;
            button1.Text = "Удалить выбранных пользователей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(212, 13);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(412, 46);
            comboBoxListUser.TabIndex = 5;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(212, 303);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(548, 46);
            comboBoxListGroup.TabIndex = 6;
            // 
            // buttonAddUserToList
            // 
            buttonAddUserToList.Location = new Point(630, 12);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(130, 47);
            buttonAddUserToList.TabIndex = 7;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += button2_Click;
            // 
            // DeleteMoreUsersFromGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 456);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteMoreUsersFromGroup";
            Text = "DeleteMoreUsersFromGroup";
            FormClosed += DeleteMoreUsersFromGroup_FormClosed;
            Load += DeleteMoreUsersFromGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxChoosedUser;
        private Button button1;
        private ComboBox comboBoxListUser;
        private ComboBox comboBoxListGroup;
        private Button buttonAddUserToList;
    }
}