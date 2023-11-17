namespace CreatorV2
{
    partial class UnlockLockUser
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
            buttonLock = new Button();
            label1 = new Label();
            comboBoxUserName = new ComboBox();
            buttonUnLock = new Button();
            SuspendLayout();
            // 
            // buttonLock
            // 
            buttonLock.Location = new Point(12, 73);
            buttonLock.Name = "buttonLock";
            buttonLock.Size = new Size(358, 102);
            buttonLock.TabIndex = 0;
            buttonLock.Text = "Заблокировать";
            buttonLock.UseVisualStyleBackColor = true;
            buttonLock.Click += button1_Click;
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
            // comboBoxUserName
            // 
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(271, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(468, 46);
            comboBoxUserName.TabIndex = 2;
            comboBoxUserName.SelectedIndexChanged += comboBoxUserName_SelectedIndexChanged;
            // 
            // buttonUnLock
            // 
            buttonUnLock.Location = new Point(381, 73);
            buttonUnLock.Name = "buttonUnLock";
            buttonUnLock.Size = new Size(358, 99);
            buttonUnLock.TabIndex = 3;
            buttonUnLock.Text = "Разблокировать";
            buttonUnLock.UseVisualStyleBackColor = true;
            buttonUnLock.Click += button2_Click;
            // 
            // UnlockLockUser
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 189);
            Controls.Add(buttonUnLock);
            Controls.Add(comboBoxUserName);
            Controls.Add(label1);
            Controls.Add(buttonLock);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UnlockLockUser";
            Text = "UnlockLockUser";
            Load += UnlockLockUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLock;
        private Label label1;
        private ComboBox comboBoxUserName;
        private Button buttonUnLock;
    }
}