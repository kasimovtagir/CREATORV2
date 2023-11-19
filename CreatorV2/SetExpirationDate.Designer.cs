namespace CreatorV2
{
    partial class SetExpirationDate
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
            buttonSaveExpirateDate = new Button();
            label1 = new Label();
            comboBoxUserName = new ComboBox();
            dateTimePickerExpirationDate = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSaveExpirateDate
            // 
            buttonSaveExpirateDate.Location = new Point(388, 117);
            buttonSaveExpirateDate.Margin = new Padding(4, 5, 4, 5);
            buttonSaveExpirateDate.Name = "buttonSaveExpirateDate";
            buttonSaveExpirateDate.Size = new Size(317, 68);
            buttonSaveExpirateDate.TabIndex = 0;
            buttonSaveExpirateDate.Text = "Установить дату";
            buttonSaveExpirateDate.UseVisualStyleBackColor = true;
            buttonSaveExpirateDate.Click += buttonSaveExpirateDate_Click;
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
            comboBoxUserName.Size = new Size(434, 46);
            comboBoxUserName.TabIndex = 2;
            // 
            // dateTimePickerExpirationDate
            // 
            dateTimePickerExpirationDate.CustomFormat = "dd.mm.yyyy";
            dateTimePickerExpirationDate.Location = new Point(388, 64);
            dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            dateTimePickerExpirationDate.Size = new Size(317, 45);
            dateTimePickerExpirationDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(370, 38);
            label2.TabIndex = 4;
            label2.Text = "Установить дату истечение ";
            // 
            // SetExpirationDate
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 194);
            Controls.Add(label2);
            Controls.Add(dateTimePickerExpirationDate);
            Controls.Add(comboBoxUserName);
            Controls.Add(label1);
            Controls.Add(buttonSaveExpirateDate);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SetExpirationDate";
            Text = "SetExpirationDate";
            Load += SetExpirationDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveExpirateDate;
        private Label label1;
        private ComboBox comboBoxUserName;
        private DateTimePicker dateTimePickerExpirationDate;
        private Label label2;
    }
}