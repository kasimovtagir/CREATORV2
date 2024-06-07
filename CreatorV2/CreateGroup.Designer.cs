namespace CreatorV2
{
    partial class CreateGroup
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
            textBoxNameGroup = new TextBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            comboBoxListUser = new ComboBox();
            label4 = new Label();
            listBoxChoosedUser = new ListBox();
            buttonAddChoosedUser = new Button();
            buttonCreateGroup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 0;
            label1.Text = "Название группы";
            // 
            // textBoxNameGroup
            // 
            textBoxNameGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameGroup.Location = new Point(258, 12);
            textBoxNameGroup.Margin = new Padding(2);
            textBoxNameGroup.Name = "textBoxNameGroup";
            textBoxNameGroup.Size = new Size(788, 45);
            textBoxNameGroup.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 38);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(162, 72);
            textBoxDescription.Margin = new Padding(2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(884, 185);
            textBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 278);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 38);
            label3.TabIndex = 4;
            label3.Text = "Пользователи";
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(214, 274);
            comboBoxListUser.Margin = new Padding(2);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(588, 46);
            comboBoxListUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 341);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(349, 38);
            label4.TabIndex = 6;
            label4.Text = "Выбранные пользователи";
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.ItemHeight = 38;
            listBoxChoosedUser.Location = new Point(396, 328);
            listBoxChoosedUser.Margin = new Padding(2);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.Size = new Size(649, 232);
            listBoxChoosedUser.TabIndex = 7;
            listBoxChoosedUser.MouseDoubleClick += listBoxChoosedUser_MouseDoubleClick;
            // 
            // buttonAddChoosedUser
            // 
            buttonAddChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddChoosedUser.Location = new Point(808, 274);
            buttonAddChoosedUser.Margin = new Padding(2);
            buttonAddChoosedUser.Name = "buttonAddChoosedUser";
            buttonAddChoosedUser.Size = new Size(239, 46);
            buttonAddChoosedUser.TabIndex = 8;
            buttonAddChoosedUser.Text = "Добавить";
            buttonAddChoosedUser.UseVisualStyleBackColor = true;
            buttonAddChoosedUser.Click += buttonAddChoosedUser_Click;
            // 
            // buttonCreateGroup
            // 
            buttonCreateGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateGroup.Location = new Point(808, 570);
            buttonCreateGroup.Margin = new Padding(2);
            buttonCreateGroup.Name = "buttonCreateGroup";
            buttonCreateGroup.Size = new Size(239, 98);
            buttonCreateGroup.TabIndex = 9;
            buttonCreateGroup.Text = "Создать группу";
            buttonCreateGroup.UseVisualStyleBackColor = true;
            buttonCreateGroup.Click += buttonCreateGroup_Click;
            // 
            // CreateGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 680);
            Controls.Add(buttonCreateGroup);
            Controls.Add(buttonAddChoosedUser);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(label4);
            Controls.Add(comboBoxListUser);
            Controls.Add(label3);
            Controls.Add(textBoxDescription);
            Controls.Add(label2);
            Controls.Add(textBoxNameGroup);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "CreateGroup";
            Text = "CreateGroup";
            FormClosing += CreateGroup_FormClosing;
            Load += CreateGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNameGroup;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private ComboBox comboBoxListUser;
        private Label label4;
        private ListBox listBoxChoosedUser;
        private Button buttonAddChoosedUser;
        private Button buttonCreateGroup;
    }
}