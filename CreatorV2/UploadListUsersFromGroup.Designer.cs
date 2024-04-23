namespace CreatorV2
{
    partial class UploadListUsersFromGroup
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
            buttonUploadListUser = new Button();
            label1 = new Label();
            comboBoxListGroup = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            listBoxListGroup = new ListBox();
            SuspendLayout();
            // 
            // buttonUploadListUser
            // 
            buttonUploadListUser.Location = new Point(298, 454);
            buttonUploadListUser.Name = "buttonUploadListUser";
            buttonUploadListUser.Size = new Size(412, 78);
            buttonUploadListUser.TabIndex = 0;
            buttonUploadListUser.Text = "Выгрузить";
            buttonUploadListUser.UseVisualStyleBackColor = true;
            buttonUploadListUser.Click += buttonUploadListUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 1;
            label1.Text = "Группа";
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(124, 12);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(406, 46);
            comboBoxListGroup.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(536, 12);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 4;
            label2.Text = "Список групп";
            // 
            // listBoxListGroup
            // 
            listBoxListGroup.FormattingEnabled = true;
            listBoxListGroup.ItemHeight = 38;
            listBoxListGroup.Location = new Point(208, 64);
            listBoxListGroup.Name = "listBoxListGroup";
            listBoxListGroup.Size = new Size(502, 384);
            listBoxListGroup.TabIndex = 5;
            // 
            // UploadListUsersFromGroup
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 546);
            Controls.Add(listBoxListGroup);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBoxListGroup);
            Controls.Add(label1);
            Controls.Add(buttonUploadListUser);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UploadListUsersFromGroup";
            Text = "UploadListUsersFromGroup";
            FormClosed += UploadListUsersFromGroup_FormClosed;
            Load += UploadListUsersFromGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUploadListUser;
        private Label label1;
        private ComboBox comboBoxListGroup;
        private Button button1;
        private Label label2;
        private ListBox listBoxListGroup;
    }
}