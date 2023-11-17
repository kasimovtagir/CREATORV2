namespace CreatorV2
{
    partial class CreateTempGroups
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
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonCreateTempGroup = new Button();
            comboBoxUserName = new ComboBox();
            comboBoxListGroup = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(261, 38);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(106, 38);
            label2.TabIndex = 1;
            label2.Text = "Группа";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(279, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(530, 45);
            dateTimePicker1.TabIndex = 2;
            // 
            // buttonCreateTempGroup
            // 
            buttonCreateTempGroup.Location = new Point(553, 167);
            buttonCreateTempGroup.Name = "buttonCreateTempGroup";
            buttonCreateTempGroup.Size = new Size(256, 78);
            buttonCreateTempGroup.TabIndex = 3;
            buttonCreateTempGroup.Text = "Создать";
            buttonCreateTempGroup.UseVisualStyleBackColor = true;
            buttonCreateTempGroup.Click += buttonCreateTempGroup_Click;
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(279, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(530, 46);
            comboBoxUserName.TabIndex = 4;
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(279, 64);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(530, 46);
            comboBoxListGroup.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 6;
            label3.Text = "Доступ до :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(91, 38);
            label4.TabIndex = 7;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // CreateTempGroups
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 259);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxListGroup);
            Controls.Add(comboBoxUserName);
            Controls.Add(buttonCreateTempGroup);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateTempGroups";
            Text = "CreateTempGroups";
            FormClosed += CreateTempGroups_FormClosed;
            Load += CreateTempGroups_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button buttonCreateTempGroup;
        private ComboBox comboBoxUserName;
        private ComboBox comboBoxListGroup;
        private Label label3;
        private Label label4;
    }
}