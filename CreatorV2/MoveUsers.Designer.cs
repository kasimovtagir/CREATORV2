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
            SuspendLayout();
            // 
            // comboBoxListOU
            // 
            comboBoxListOU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListOU.FormattingEnabled = true;
            comboBoxListOU.Location = new Point(172, 120);
            comboBoxListOU.Name = "comboBoxListOU";
            comboBoxListOU.Size = new Size(516, 39);
            comboBoxListOU.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 120);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 19;
            label3.Text = "В какой OU=";
            // 
            // comboBoxListUser
            // 
            comboBoxListUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUser.FormattingEnabled = true;
            comboBoxListUser.Location = new Point(172, 69);
            comboBoxListUser.Margin = new Padding(2);
            comboBoxListUser.Name = "comboBoxListUser";
            comboBoxListUser.Size = new Size(516, 39);
            comboBoxListUser.TabIndex = 18;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(172, 164);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(516, 92);
            button1.TabIndex = 17;
            button1.Text = "Перенести выбранных пользователей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 16;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 22;
            label2.Text = "Из какого OU=";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(490, 39);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MoveUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 372);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(comboBoxListOU);
            Controls.Add(label3);
            Controls.Add(comboBoxListUser);
            Controls.Add(button1);
            Controls.Add(label1);
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
    }
}