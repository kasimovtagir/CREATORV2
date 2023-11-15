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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonSaveNewPasswordForUser
            // 
            buttonSaveNewPasswordForUser.Location = new Point(722, 127);
            buttonSaveNewPasswordForUser.Name = "buttonSaveNewPasswordForUser";
            buttonSaveNewPasswordForUser.Size = new Size(235, 75);
            buttonSaveNewPasswordForUser.TabIndex = 0;
            buttonSaveNewPasswordForUser.Text = "Сохранить";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(686, 46);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(686, 45);
            textBox1.TabIndex = 4;
            // 
            // ChangePasswordForUser
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 221);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveNewPasswordForUser);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChangePasswordForUser";
            Text = "ChangePasswordForUser";
            Load += ChangePasswordForUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveNewPasswordForUser;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}