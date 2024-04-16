namespace CreatorV2
{
    partial class MoveUsers
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
            comboBoxListOU = new ComboBox();
            label3 = new Label();
            comboBoxListUser = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            checkBoxBlockUser = new CheckBox();
            SuspendLayout();
            // 
            // comboBoxListOU
            // 
            comboBoxListOU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListOU.FormattingEnabled = true;
            comboBoxListOU.Location = new Point(150, 90);
            comboBoxListOU.Margin = new Padding(3, 2, 3, 2);
            comboBoxListOU.Name = "comboBoxListOU";
            comboBoxListOU.Size = new Size(452, 33);
            comboBoxListOU.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 90);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 19;
            label3.Text = "В какой OU=";
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(150, 52);
            comboBoxListUser.Margin = new Padding(2);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(452, 33);
            comboBoxListUser.TabIndex = 18;
            comboBoxListUser.SelectedIndexChanged += comboBoxListUser_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(150, 186);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(452, 69);
            button1.TabIndex = 17;
            button1.Text = "Перенести выбранных пользователей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 16;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 11);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 22;
            label2.Text = "Из какого OU=";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 9);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(429, 33);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBoxBlockUser
            // 
            checkBoxBlockUser.AutoSize = true;
            checkBoxBlockUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBlockUser.Location = new Point(8, 128);
            checkBoxBlockUser.Name = "checkBoxBlockUser";
            checkBoxBlockUser.Size = new Size(287, 29);
            checkBoxBlockUser.TabIndex = 23;
            checkBoxBlockUser.Text = "Заблокировать пользователя";
            checkBoxBlockUser.UseVisualStyleBackColor = true;
            // 
            // MoveUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 279);
            Controls.Add(checkBoxBlockUser);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(comboBoxListOU);
            Controls.Add(label3);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MoveUsers";
            Text = "MoveUsers";
            FormClosing += MoveUsers_FormClosing;
            Load += MoveUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxListOU;
        private Label label3;
        private ComboBox comboBoxListUser;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private CheckBox checkBoxBlockUser;
    }
}