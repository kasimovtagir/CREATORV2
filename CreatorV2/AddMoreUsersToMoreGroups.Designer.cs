namespace CreatorV2
{
    partial class AddMoreUsersToMoreGroups
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
            buttonAddUser = new Button();
            comboBoxListUser = new ComboBox();
            comboBoxListGroup = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            buttonAddGroups = new Button();
            buttonMoreAdd = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = SystemColors.Control;
            buttonAddUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUser.Location = new Point(681, 12);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(157, 42);
            buttonAddUser.TabIndex = 0;
            buttonAddUser.Text = "Добавить";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAdd_Click;
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(285, 15);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(390, 39);
            comboBoxListUser.TabIndex = 1;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(182, 184);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(489, 39);
            comboBoxListGroup.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 3;
            label1.Text = "Список пользователей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 4;
            label2.Text = "Список групп";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(321, 60);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(517, 97);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 31;
            listBox2.Location = new Point(248, 229);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(590, 128);
            listBox2.TabIndex = 6;
            listBox2.MouseDoubleClick += listBox2_MouseDoubleClick;
            // 
            // buttonAddGroups
            // 
            buttonAddGroups.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddGroups.Location = new Point(677, 184);
            buttonAddGroups.Name = "buttonAddGroups";
            buttonAddGroups.Size = new Size(161, 39);
            buttonAddGroups.TabIndex = 7;
            buttonAddGroups.Text = "Добавить";
            buttonAddGroups.UseVisualStyleBackColor = true;
            buttonAddGroups.Click += buttonAddGroups_Click;
            // 
            // buttonMoreAdd
            // 
            buttonMoreAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoreAdd.Location = new Point(248, 421);
            buttonMoreAdd.Name = "buttonMoreAdd";
            buttonMoreAdd.Size = new Size(590, 59);
            buttonMoreAdd.TabIndex = 8;
            buttonMoreAdd.Text = "Добавить пользователей в группу";
            buttonMoreAdd.UseVisualStyleBackColor = true;
            buttonMoreAdd.Click += buttonMoreAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(303, 32);
            label3.TabIndex = 9;
            label3.Text = "Выбранные пользователи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(230, 32);
            label4.TabIndex = 10;
            label4.Text = "Выбранные группы";
            // 
            // AddMoreUsersToMoreGroups
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 493);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonMoreAdd);
            Controls.Add(buttonAddGroups);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxListUser);
            Controls.Add(buttonAddUser);
            Name = "AddMoreUsersToMoreGroups";
            Text = "AddMoreUsersToMoreGroups";
            FormClosing += AddMoreUsersToMoreGroups_FormClosing;
            Load += AddMoreUsersToMoreGroups_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUser;
        private ComboBox comboBoxListUser;
        private ComboBox comboBoxListGroup;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button buttonAddGroups;
        private Button buttonMoreAdd;
        private Label label3;
        private Label label4;
    }
}