namespace CreatorV2
{
    partial class AddUserInGroup
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
            comboBoxUserName = new ComboBox();
            buttonAddUserToGroup = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxGroup = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(271, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(455, 46);
            comboBoxUserName.TabIndex = 1;
            // 
            // buttonAddUserToGroup
            // 
            buttonAddUserToGroup.Location = new Point(504, 116);
            buttonAddUserToGroup.Name = "buttonAddUserToGroup";
            buttonAddUserToGroup.Size = new Size(223, 66);
            buttonAddUserToGroup.TabIndex = 2;
            buttonAddUserToGroup.Text = "Добавить";
            buttonAddUserToGroup.UseVisualStyleBackColor = true;
            buttonAddUserToGroup.Click += buttonAddUserToGroup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 3;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 4;
            label2.Text = "Группа";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(271, 64);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(455, 46);
            comboBoxGroup.TabIndex = 5;
            // 
            // AddUserInGroup
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 199);
            Controls.Add(comboBoxGroup);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddUserToGroup);
            Controls.Add(comboBoxUserName);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddUserInGroup";
            Text = "AddUserInGroup";
            FormClosed += AddUserInGroup_FormClosed;
            Load += AddUserInGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserName;
        private Button buttonAddUserToGroup;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxGroup;
    }
}