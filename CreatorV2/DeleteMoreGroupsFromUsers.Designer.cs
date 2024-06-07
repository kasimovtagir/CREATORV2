namespace CreatorV2
{
    partial class DeleteMoreGroupsFromUsers
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
            listBoxChoosedGroup = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAddUserToList
            // 
            buttonAddUserToList.Location = new Point(517, 53);
            buttonAddUserToList.Margin = new Padding(2);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(104, 38);
            buttonAddUserToList.TabIndex = 31;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += buttonAddUserToList_Click;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(183, 53);
            comboBoxListGroup.Margin = new Padding(2);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(330, 39);
            comboBoxListGroup.TabIndex = 30;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(183, 10);
            comboBoxListUser.Margin = new Padding(2);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(438, 39);
            comboBoxListUser.TabIndex = 29;
            comboBoxListUser.SelectedIndexChanged += comboBoxListUser_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(184, 259);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(438, 68);
            button1.TabIndex = 28;
            button1.Text = "Удалить выбранные группы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxChoosedGroup
            // 
            listBoxChoosedGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedGroup.FormattingEnabled = true;
            listBoxChoosedGroup.HorizontalScrollbar = true;
            listBoxChoosedGroup.ItemHeight = 31;
            listBoxChoosedGroup.Location = new Point(183, 96);
            listBoxChoosedGroup.Margin = new Padding(2);
            listBoxChoosedGroup.Name = "listBoxChoosedGroup";
            listBoxChoosedGroup.ScrollAlwaysVisible = true;
            listBoxChoosedGroup.Size = new Size(439, 159);
            listBoxChoosedGroup.TabIndex = 27;
            listBoxChoosedGroup.MouseDoubleClick += listBoxChoosedGroup_MouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 26;
            label3.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 25;
            label2.Text = "Выбранные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 24;
            label1.Text = "Группы";
            // 
            // DeleteMoreGroupsFromUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 343);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedGroup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteMoreGroupsFromUsers";
            Text = "DeleteMoreGroupsFromUsers";
            FormClosing += DeleteMoreGroupsFromUsers_FormClosing;
            Load += DeleteMoreGroupsFromUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUserToList;
        private ComboBox comboBoxListGroup;
        private ComboBox comboBoxListUser;
        private Button button1;
        private ListBox listBoxChoosedGroup;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}