namespace CreatorV2
{
    partial class DefPasswordForUser
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
            buttonSavePAssForUser = new Button();
            label1 = new Label();
            textBoxDefPassForUser = new TextBox();
            SuspendLayout();
            // 
            // buttonSavePAssForUser
            // 
            buttonSavePAssForUser.Location = new Point(12, 101);
            buttonSavePAssForUser.Name = "buttonSavePAssForUser";
            buttonSavePAssForUser.Size = new Size(359, 73);
            buttonSavePAssForUser.TabIndex = 0;
            buttonSavePAssForUser.Text = "Сохранить";
            buttonSavePAssForUser.UseVisualStyleBackColor = true;
            buttonSavePAssForUser.Click += buttonSavePAssForUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 38);
            label1.TabIndex = 1;
            label1.Text = "Пароль для пользователя: ";
            // 
            // textBoxDefPassForUser
            // 
            textBoxDefPassForUser.Location = new Point(12, 50);
            textBoxDefPassForUser.Name = "textBoxDefPassForUser";
            textBoxDefPassForUser.Size = new Size(359, 45);
            textBoxDefPassForUser.TabIndex = 2;
            // 
            // DefPasswordForUser
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 184);
            Controls.Add(textBoxDefPassForUser);
            Controls.Add(label1);
            Controls.Add(buttonSavePAssForUser);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DefPasswordForUser";
            Text = "DefPasswordForUser";
            Load += DefPasswordForUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSavePAssForUser;
        private Label label1;
        private TextBox textBoxDefPassForUser;
    }
}