namespace CreatorV2
{
    partial class DeleteUserFromGroup
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
            comboBoxListGroup = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            buttonDeleteUserFromGroup = new Button();
            comboBoxUserName = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(270, 64);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(455, 46);
            comboBoxListGroup.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 67);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 9;
            label2.Text = "Группа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 8;
            label1.Text = "Имя пользователя";
            // 
            // buttonDeleteUserFromGroup
            // 
            buttonDeleteUserFromGroup.Location = new Point(459, 116);
            buttonDeleteUserFromGroup.Name = "buttonDeleteUserFromGroup";
            buttonDeleteUserFromGroup.Size = new Size(267, 66);
            buttonDeleteUserFromGroup.TabIndex = 7;
            buttonDeleteUserFromGroup.Text = "Удалить";
            buttonDeleteUserFromGroup.UseVisualStyleBackColor = true;
            buttonDeleteUserFromGroup.Click += buttonDeleteUserFromGroup_Click;
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(270, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(455, 46);
            comboBoxUserName.TabIndex = 6;
            comboBoxUserName.SelectedIndexChanged += comboBoxUserName_SelectedIndexChanged;
            // 
            // DeleteUserFromGroup
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 197);
            Controls.Add(comboBoxListGroup);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeleteUserFromGroup);
            Controls.Add(comboBoxUserName);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DeleteUserFromGroup";
            Text = "DeleteUserFromGroup";
            FormClosed += DeleteUserFromGroup_FormClosed;
            Load += DeleteUserFromGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxListGroup;
        private Label label2;
        private Label label1;
        private Button buttonDeleteUserFromGroup;
        private ComboBox comboBoxUserName;
    }
}