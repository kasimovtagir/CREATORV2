namespace CreatorV2
{
    partial class UploadListGroupAtUser
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
            listBoxListUser = new ListBox();
            label2 = new Label();
            button1 = new Button();
            comboBoxUserName = new ComboBox();
            label1 = new Label();
            buttonUploadListUser = new Button();
            SuspendLayout();
            // 
            // listBoxListUser
            // 
            listBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListUser.FormattingEnabled = true;
            listBoxListUser.ItemHeight = 38;
            listBoxListUser.Location = new Point(222, 64);
            listBoxListUser.Name = "listBoxListUser";
            listBoxListUser.Size = new Size(586, 384);
            listBoxListUser.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(109, 38);
            label2.TabIndex = 10;
            label2.Text = "Список";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(634, 12);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(222, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(406, 46);
            comboBoxUserName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 7;
            label1.Text = "Пользователь";
            // 
            // buttonUploadListUser
            // 
            buttonUploadListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUploadListUser.Location = new Point(287, 454);
            buttonUploadListUser.Name = "buttonUploadListUser";
            buttonUploadListUser.Size = new Size(412, 78);
            buttonUploadListUser.TabIndex = 6;
            buttonUploadListUser.Text = "Выгрузить";
            buttonUploadListUser.UseVisualStyleBackColor = true;
            buttonUploadListUser.Click += buttonUploadListUser_Click;
            // 
            // UploadListGroupAtUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 549);
            Controls.Add(listBoxListUser);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBoxUserName);
            Controls.Add(label1);
            Controls.Add(buttonUploadListUser);
            Name = "UploadListGroupAtUser";
            Text = "UploadListGroupAtUser";
            FormClosing += UploadListGroupAtUser_FormClosing;
            Load += UploadListGroupAtUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxListUser;
        private Label label2;
        private Button button1;
        private ComboBox comboBoxUserName;
        private Label label1;
        private Button buttonUploadListUser;
    }
}