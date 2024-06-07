namespace CreatorV2
{
    partial class SingleDeleteOrAddUserToGroups
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
            label3 = new Label();
            label4 = new Label();
            comboBoxGroup = new ComboBox();
            comboBoxUserName = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(475, 147);
            button1.Name = "button1";
            button1.Size = new Size(258, 98);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 6;
            label3.Text = "Группа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 26);
            label4.Name = "label4";
            label4.Size = new Size(260, 32);
            label4.TabIndex = 5;
            label4.Text = "Имя пользователя";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(278, 95);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(455, 46);
            comboBoxGroup.TabIndex = 8;
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(278, 18);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(455, 46);
            comboBoxUserName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 67);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 9;
            label1.Text = "На английском, Name LastName";
            // 
            // SingleDeleteOrAddUserToGroups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 256);
            Controls.Add(label1);
            Controls.Add(comboBoxGroup);
            Controls.Add(comboBoxUserName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Name = "SingleDeleteOrAddUserToGroups";
            Text = "SingleDeleteOrAddUserToGroups";
            FormClosed += SingleDeleteOrAddUserToGroups_FormClosed;
            Load += SingleDeleteOrAddUserToGroups_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxGroup;
        private ComboBox comboBoxUserName;
        private Label label1;
    }
}