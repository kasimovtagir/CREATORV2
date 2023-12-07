namespace CreatorV2
{
    partial class PreviewCreateUsersAccountWithoutSendEmail
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
            buttonCreateAccountWithoutSendEmail = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAccount = new TextBox();
            textBoxPassword = new TextBox();
            textBoxListGroup = new TextBox();
            checkBoxShwoPassword = new CheckBox();
            SuspendLayout();
            // 
            // buttonCreateAccountWithoutSendEmail
            // 
            buttonCreateAccountWithoutSendEmail.Location = new Point(309, 329);
            buttonCreateAccountWithoutSendEmail.Name = "buttonCreateAccountWithoutSendEmail";
            buttonCreateAccountWithoutSendEmail.Size = new Size(346, 62);
            buttonCreateAccountWithoutSendEmail.TabIndex = 0;
            buttonCreateAccountWithoutSendEmail.Text = "Создать учетную запись";
            buttonCreateAccountWithoutSendEmail.UseVisualStyleBackColor = true;
            buttonCreateAccountWithoutSendEmail.Click += buttonCreateAccountWithoutSendEmail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 1;
            label1.Text = "Учетная запись";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 3;
            label3.Text = "Список групп";
            // 
            // textBoxAccount
            // 
            textBoxAccount.Enabled = false;
            textBoxAccount.Location = new Point(202, 12);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.Size = new Size(453, 39);
            textBoxAccount.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new Point(202, 57);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(453, 39);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxListGroup
            // 
            textBoxListGroup.Enabled = false;
            textBoxListGroup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxListGroup.Location = new Point(12, 182);
            textBoxListGroup.Multiline = true;
            textBoxListGroup.Name = "textBoxListGroup";
            textBoxListGroup.Size = new Size(643, 141);
            textBoxListGroup.TabIndex = 6;
            textBoxListGroup.TextChanged += textBox3_TextChanged;
            // 
            // checkBoxShwoPassword
            // 
            checkBoxShwoPassword.AutoSize = true;
            checkBoxShwoPassword.Location = new Point(12, 102);
            checkBoxShwoPassword.Name = "checkBoxShwoPassword";
            checkBoxShwoPassword.Size = new Size(222, 36);
            checkBoxShwoPassword.TabIndex = 7;
            checkBoxShwoPassword.Text = "Показать пароль";
            checkBoxShwoPassword.UseVisualStyleBackColor = true;
            checkBoxShwoPassword.CheckedChanged += checkBoxShwoPassword_CheckedChanged;
            // 
            // PreviewCreateUsersAccountWithoutSendEmail
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 400);
            Controls.Add(checkBoxShwoPassword);
            Controls.Add(textBoxListGroup);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAccount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCreateAccountWithoutSendEmail);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PreviewCreateUsersAccountWithoutSendEmail";
            Text = "PreviewCreateUsersAccountWithoutSendEmail";
            Load += PreviewCreateUsersAccountWithoutSendEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreateAccountWithoutSendEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAccount;
        private TextBox textBoxPassword;
        private TextBox textBoxListGroup;
        private CheckBox checkBoxShwoPassword;
    }
}