namespace CreatorV2
{
    partial class AddMoreGroupsToUser
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
            buttonAddUserToList.Location = new Point(516, 58);
            buttonAddUserToList.Margin = new Padding(2);
            buttonAddUserToList.Name = "buttonAddUserToList";
            buttonAddUserToList.Size = new Size(104, 38);
            buttonAddUserToList.TabIndex = 23;
            buttonAddUserToList.Text = "Добавить";
            buttonAddUserToList.UseVisualStyleBackColor = true;
            buttonAddUserToList.Click += buttonAddUserToList_Click;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(182, 58);
            comboBoxListGroup.Margin = new Padding(2);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(330, 39);
            comboBoxListGroup.TabIndex = 22;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(182, 15);
            comboBoxListUser.Margin = new Padding(2);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(438, 39);
            comboBoxListUser.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(182, 264);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(438, 68);
            button1.TabIndex = 20;
            button1.Text = "Добавить выбранные группы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxChoosedGroup
            // 
            listBoxChoosedGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedGroup.FormattingEnabled = true;
            listBoxChoosedGroup.HorizontalScrollbar = true;
            listBoxChoosedGroup.ItemHeight = 31;
            listBoxChoosedGroup.Location = new Point(182, 101);
            listBoxChoosedGroup.Margin = new Padding(2);
            listBoxChoosedGroup.Name = "listBoxChoosedGroup";
            listBoxChoosedGroup.ScrollAlwaysVisible = true;
            listBoxChoosedGroup.Size = new Size(439, 159);
            listBoxChoosedGroup.TabIndex = 19;
            listBoxChoosedGroup.MouseDoubleClick += listBoxChoosedGroup_MouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 18;
            label3.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 17;
            label2.Text = "Выбранные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 16;
            label1.Text = "Группы";
            // 
            // AddMoreGroupsToUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 342);
            Controls.Add(buttonAddUserToList);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(listBoxChoosedGroup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddMoreGroupsToUser";
            Text = "AddMoreGroupsToUser";
            FormClosed += AddMoreGroupsToUser_FormClosed;
            Load += AddMoreGroupsToUser_Load;
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