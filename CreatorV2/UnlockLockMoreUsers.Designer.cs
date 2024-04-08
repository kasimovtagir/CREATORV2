namespace CreatorV2
{
    partial class UnlockLockMoreUsers
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxListUser = new ComboBox();
            listBoxChoosedUser = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(321, 483);
            button1.Name = "button1";
            button1.Size = new Size(595, 73);
            button1.TabIndex = 0;
            button1.Text = "Заблокировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 1;
            label1.Text = "Список пользователей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(303, 32);
            label2.TabIndex = 2;
            label2.Text = "Выбранные пользователи";
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(285, 12);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(485, 39);
            comboBoxListUser.TabIndex = 3;
            // 
            // listBoxChoosedUser
            // 
            listBoxChoosedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUser.FormattingEnabled = true;
            listBoxChoosedUser.ItemHeight = 31;
            listBoxChoosedUser.Location = new Point(321, 68);
            listBoxChoosedUser.Name = "listBoxChoosedUser";
            listBoxChoosedUser.Size = new Size(595, 407);
            listBoxChoosedUser.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(776, 12);
            button2.Name = "button2";
            button2.Size = new Size(140, 39);
            button2.TabIndex = 5;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UnlockLockMoreUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 569);
            Controls.Add(button2);
            Controls.Add(listBoxChoosedUser);
            Controls.Add(comboBoxListUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "UnlockLockMoreUsers";
            Text = "UnlockLockMoreUsers";
            FormClosing += UnlockLockMoreUsers_FormClosing;
            Load += UnlockLockMoreUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxListUser;
        private ListBox listBoxChoosedUser;
        private Button button2;
    }
}