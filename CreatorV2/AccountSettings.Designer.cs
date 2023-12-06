namespace CreatorV2
{
    partial class AccountSettings
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
        /// Required method for Designer support - do not mo
        /// y
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSaveSettings = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNameLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Location = new Point(12, 217);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(631, 89);
            buttonSaveSettings.TabIndex = 0;
            buttonSaveSettings.Text = "Сохранить";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 1;
            label1.Text = "Имя Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // textBoxNameLastName
            // 
            textBoxNameLastName.Location = new Point(213, 12);
            textBoxNameLastName.Name = "textBoxNameLastName";
            textBoxNameLastName.Size = new Size(430, 39);
            textBoxNameLastName.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(213, 63);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(430, 39);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(213, 114);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(430, 39);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(12, 169);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(222, 36);
            checkBoxShowPassword.TabIndex = 7;
            checkBoxShowPassword.Text = "Показать пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AccountSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 323);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNameLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveSettings);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AccountSettings";
            Text = "Настройка аккаунта для отправки письма";
            Load += AccountSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveSettings;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNameLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
    }
}