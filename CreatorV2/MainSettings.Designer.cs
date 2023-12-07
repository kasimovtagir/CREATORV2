namespace CreatorV2
{
    partial class MainSettings
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
            buttonSaveMainSettings = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxUserName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxUserPassword = new TextBox();
            textBoxNetbios = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxListOU = new ComboBox();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // buttonSaveMainSettings
            // 
            buttonSaveMainSettings.Location = new Point(621, 302);
            buttonSaveMainSettings.Margin = new Padding(4, 5, 4, 5);
            buttonSaveMainSettings.Name = "buttonSaveMainSettings";
            buttonSaveMainSettings.Size = new Size(227, 81);
            buttonSaveMainSettings.TabIndex = 0;
            buttonSaveMainSettings.Text = "Сохранить";
            buttonSaveMainSettings.UseVisualStyleBackColor = true;
            buttonSaveMainSettings.Click += buttonSaveMainSettings_Click;
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
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 38);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(126, 38);
            label4.TabIndex = 4;
            label4.Text = "NETBIOS";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(271, 12);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(577, 45);
            textBoxUserName.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(271, 63);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(577, 45);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Location = new Point(271, 114);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.PasswordChar = '*';
            textBoxUserPassword.Size = new Size(577, 45);
            textBoxUserPassword.TabIndex = 8;
            // 
            // textBoxNetbios
            // 
            textBoxNetbios.Location = new Point(271, 165);
            textBoxNetbios.Name = "textBoxNetbios";
            textBoxNetbios.Size = new Size(577, 45);
            textBoxNetbios.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(508, 28);
            label5.TabIndex = 10;
            label5.Text = "Если поле NETBIOS введен не коретно, поменяйте его";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 240);
            label6.Name = "label6";
            label6.Size = new Size(57, 38);
            label6.TabIndex = 11;
            label6.Text = "OU";
            // 
            // comboBoxListOU
            // 
            comboBoxListOU.FormattingEnabled = true;
            comboBoxListOU.Location = new Point(271, 237);
            comboBoxListOU.Name = "comboBoxListOU";
            comboBoxListOU.Size = new Size(577, 46);
            comboBoxListOU.TabIndex = 12;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(12, 302);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(257, 42);
            checkBoxShowPassword.TabIndex = 13;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // MainSettings
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 401);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(comboBoxListOU);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxNetbios);
            Controls.Add(textBoxUserPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveMainSettings);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainSettings";
            Text = "MainSettings";
            Load += MainSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveMainSettings;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxUserName;
        private TextBox textBoxEmail;
        private TextBox textBoxUserPassword;
        private TextBox textBoxNetbios;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxListOU;
        private CheckBox checkBoxShowPassword;
    }
}