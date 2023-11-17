namespace CreatorV2
{
    partial class ChangePasswordForUser
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
            buttonSaveNewPasswordForUser = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxUserName = new ComboBox();
            textBoxNewPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // buttonSaveNewPasswordForUser
            // 
            buttonSaveNewPasswordForUser.Location = new Point(553, 127);
            buttonSaveNewPasswordForUser.Name = "buttonSaveNewPasswordForUser";
            buttonSaveNewPasswordForUser.Size = new Size(404, 75);
            buttonSaveNewPasswordForUser.TabIndex = 0;
            buttonSaveNewPasswordForUser.Text = "Поменять пароль";
            buttonSaveNewPasswordForUser.UseVisualStyleBackColor = true;
            buttonSaveNewPasswordForUser.Click += buttonSaveNewPasswordForUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 1;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(203, 38);
            label2.TabIndex = 2;
            label2.Text = "Новый пароль";
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(271, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(686, 46);
            comboBoxUserName.TabIndex = 3;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(271, 64);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(686, 45);
            textBoxNewPassword.TabIndex = 4;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(48, 151);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(257, 42);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChangePasswordForUser
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 221);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(comboBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveNewPasswordForUser);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChangePasswordForUser";
            Text = "ChangePasswordForUser";
            FormClosed += ChangePasswordForUser_FormClosed;
            Load += ChangePasswordForUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveNewPasswordForUser;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxUserName;
        private TextBox textBoxNewPassword;
        private CheckBox checkBoxShowPassword;
    }
}