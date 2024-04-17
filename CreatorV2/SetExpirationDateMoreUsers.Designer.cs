namespace CreatorV2
{
    partial class SetExpirationDateMoreUsers
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
            label3 = new Label();
            comboBoxListUsers = new ComboBox();
            listBoxChoosedUsers = new ListBox();
            buttonAddToList = new Button();
            buttonExpirateDate = new Button();
            dateTimePickerExpirationDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 0;
            label1.Text = "Список пользователей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 94);
            label2.Name = "label2";
            label2.Size = new Size(349, 38);
            label2.TabIndex = 1;
            label2.Text = "Выбранные пользователи";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 269);
            label3.Name = "label3";
            label3.Size = new Size(369, 38);
            label3.TabIndex = 2;
            label3.Text = "Установить дату истечения ";
            // 
            // comboBoxListUsers
            // 
            comboBoxListUsers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListUsers.FormattingEnabled = true;
            comboBoxListUsers.Location = new Point(325, 12);
            comboBoxListUsers.Name = "comboBoxListUsers";
            comboBoxListUsers.Size = new Size(463, 46);
            comboBoxListUsers.TabIndex = 3;
            // 
            // listBoxChoosedUsers
            // 
            listBoxChoosedUsers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxChoosedUsers.FormattingEnabled = true;
            listBoxChoosedUsers.ItemHeight = 38;
            listBoxChoosedUsers.Location = new Point(378, 64);
            listBoxChoosedUsers.Name = "listBoxChoosedUsers";
            listBoxChoosedUsers.Size = new Size(599, 194);
            listBoxChoosedUsers.TabIndex = 4;
            // 
            // buttonAddToList
            // 
            buttonAddToList.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddToList.Location = new Point(805, 12);
            buttonAddToList.Name = "buttonAddToList";
            buttonAddToList.Size = new Size(172, 46);
            buttonAddToList.TabIndex = 5;
            buttonAddToList.Text = "Добавить";
            buttonAddToList.UseVisualStyleBackColor = true;
            buttonAddToList.Click += buttonAddToList_Click;
            // 
            // buttonExpirateDate
            // 
            buttonExpirateDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExpirateDate.Location = new Point(576, 315);
            buttonExpirateDate.Name = "buttonExpirateDate";
            buttonExpirateDate.Size = new Size(401, 74);
            buttonExpirateDate.TabIndex = 6;
            buttonExpirateDate.Text = "Установить";
            buttonExpirateDate.UseVisualStyleBackColor = true;
            buttonExpirateDate.Click += buttonExpirateDate_Click;
            // 
            // dateTimePickerExpirationDate
            // 
            dateTimePickerExpirationDate.CustomFormat = "dd.mm.yyyy";
            dateTimePickerExpirationDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerExpirationDate.Location = new Point(387, 264);
            dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            dateTimePickerExpirationDate.Size = new Size(372, 45);
            dateTimePickerExpirationDate.TabIndex = 7;
            // 
            // SetExpirationDateMoreUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 401);
            Controls.Add(dateTimePickerExpirationDate);
            Controls.Add(buttonExpirateDate);
            Controls.Add(buttonAddToList);
            Controls.Add(listBoxChoosedUsers);
            Controls.Add(comboBoxListUsers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SetExpirationDateMoreUsers";
            Text = "SetExpirationDateMoreUsers";
            Load += SetExpirationDateMoreUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxListUsers;
        private ListBox listBoxChoosedUsers;
        private Button buttonAddToList;
        private Button buttonExpirateDate;
        private DateTimePicker dateTimePickerExpirationDate;
    }
}