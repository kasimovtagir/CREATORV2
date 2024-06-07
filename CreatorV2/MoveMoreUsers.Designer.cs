namespace CreatorV2
{
    partial class MoveMoreUsers
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
            comboBoxListUser = new ComboBox();
            button1 = new Button();
            listBoxChoosedUser = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBoxListOU = new ComboBox();
            label4 = new Label();
            comboBoxFromOU = new ComboBox();
            checkBoxLock = new CheckBox();
            checkBoxUnlock = new CheckBox();
            SuspendLayout();
            // 
            // buttonAddUserToList
            // 
            buttonAddUserToList.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUserToList.Location = new Point(517, 57);
            buttonAddUserToList.Margin = new Padding(2, 3, 2, 3);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(182, 45);
            buttonAddUserToList.TabIndex = 13;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += buttonAddUserToList_Click;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(182, 60);
            comboBoxListUser.Margin = new Padding(2, 3, 2, 3);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(330, 39);
            comboBoxListUser.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(182, 493);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(517, 92);
            button1.TabIndex = 11;
            button1.Text = "Перенести выбранных пользователей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.HorizontalScrollbar = true;
            listBoxChoosedUser.ItemHeight = 31;
            listBoxChoosedUser.Location = new Point(182, 109);
            listBoxChoosedUser.Margin = new Padding(2, 3, 2, 3);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.ScrollAlwaysVisible = true;
            listBoxChoosedUser.Size = new Size(516, 252);
            listBoxChoosedUser.TabIndex = 10;
            listBoxChoosedUser.MouseDoubleClick += listBoxChoosedUser_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 9;
            label2.Text = "Выбранные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 8;
            label1.Text = "Пользователь";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 401);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 14;
            label3.Text = "В какой OU=";
            // 
            // comboBoxListOU
            // 
            comboBoxListOU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListOU.FormattingEnabled = true;
            comboBoxListOU.Location = new Point(182, 397);
            comboBoxListOU.Name = "comboBoxListOU";
            comboBoxListOU.Size = new Size(516, 39);
            comboBoxListOU.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 15);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 24;
            label4.Text = "Из какого OU=";
            // 
            // comboBoxFromOU
            // 
            comboBoxFromOU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFromOU.FormattingEnabled = true;
            comboBoxFromOU.Location = new Point(197, 12);
            comboBoxFromOU.Name = "comboBoxFromOU";
            comboBoxFromOU.Size = new Size(502, 39);
            comboBoxFromOU.TabIndex = 23;
            comboBoxFromOU.SelectedIndexChanged += comboBoxFromOU_SelectedIndexChanged;
            // 
            // checkBoxLock
            // 
            checkBoxLock.AutoSize = true;
            checkBoxLock.Checked = true;
            checkBoxLock.CheckState = CheckState.Checked;
            checkBoxLock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxLock.Location = new Point(182, 448);
            checkBoxLock.Margin = new Padding(3, 4, 3, 4);
            checkBoxLock.Name = "checkBoxLock";
            checkBoxLock.Size = new Size(231, 36);
            checkBoxLock.TabIndex = 25;
            checkBoxLock.Text = "ЗАБЛОКИРОВАТЬ";
            checkBoxLock.UseVisualStyleBackColor = true;
            checkBoxLock.CheckedChanged += checkBoxLock_CheckedChanged;
            // 
            // checkBoxUnlock
            // 
            checkBoxUnlock.AutoSize = true;
            checkBoxUnlock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUnlock.Location = new Point(474, 448);
            checkBoxUnlock.Margin = new Padding(3, 4, 3, 4);
            checkBoxUnlock.Name = "checkBoxUnlock";
            checkBoxUnlock.Size = new Size(244, 36);
            checkBoxUnlock.TabIndex = 26;
            checkBoxUnlock.Text = "РАЗБЛОКИРОВАТЬ";
            checkBoxUnlock.UseVisualStyleBackColor = true;
            checkBoxUnlock.CheckedChanged += checkBoxUnlock_CheckedChanged;
            // 
            // MoveMoreUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 607);
            Controls.Add(checkBoxUnlock);
            Controls.Add(checkBoxLock);
            Controls.Add(label4);
            Controls.Add(comboBoxFromOU);
            Controls.Add(comboBoxListOU);
            Controls.Add(label3);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MoveMoreUsers";
            Text = "MoveMoreUsers";
            FormClosing += MoveMoreUsers_FormClosing;
            Load += MoveMoreUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUserToList;
        private ComboBox comboBoxListUser;
        private Button button1;
        private ListBox listBoxChoosedUser;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxListOU;
        private Label label4;
        private ComboBox comboBoxFromOU;
        private CheckBox checkBoxLock;
        private CheckBox checkBoxUnlock;
    }
}