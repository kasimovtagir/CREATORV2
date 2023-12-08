namespace CreatorV2
{
    partial class PreviewCreateUsersAccountWithSendEmail
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
            label4 = new Label();
            textBoxTo = new TextBox();
            textBoxFrom = new TextBox();
            textBoxSubject = new TextBox();
            textBoxListGroup = new TextBox();
            textBoxMessageMetxt = new TextBox();
            label5 = new Label();
            checkBoxRUS = new CheckBox();
            checkBoxENG = new CheckBox();
            buttonCreateUserinAD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(97, 38);
            label1.TabIndex = 0;
            label1.Text = "Кому: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 38);
            label2.TabIndex = 1;
            label2.Text = "От: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(188, 38);
            label3.TabIndex = 2;
            label3.Text = "Тема письма:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 178);
            label4.Name = "label4";
            label4.Size = new Size(196, 38);
            label4.TabIndex = 3;
            label4.Text = "Список групп:";
            // 
            // textBoxTo
            // 
            textBoxTo.Enabled = false;
            textBoxTo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTo.Location = new Point(115, 18);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(1063, 45);
            textBoxTo.TabIndex = 4;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Enabled = false;
            textBoxFrom.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFrom.Location = new Point(115, 69);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(1063, 45);
            textBoxFrom.TabIndex = 5;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Enabled = false;
            textBoxSubject.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSubject.Location = new Point(211, 120);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(967, 45);
            textBoxSubject.TabIndex = 6;
            // 
            // textBoxListGroup
            // 
            textBoxListGroup.Enabled = false;
            textBoxListGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxListGroup.Location = new Point(211, 171);
            textBoxListGroup.Multiline = true;
            textBoxListGroup.Name = "textBoxListGroup";
            textBoxListGroup.ScrollBars = ScrollBars.Vertical;
            textBoxListGroup.Size = new Size(967, 104);
            textBoxListGroup.TabIndex = 7;
            // 
            // textBoxMessageMetxt
            // 
            textBoxMessageMetxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMessageMetxt.Location = new Point(12, 314);
            textBoxMessageMetxt.Multiline = true;
            textBoxMessageMetxt.Name = "textBoxMessageMetxt";
            textBoxMessageMetxt.ScrollBars = ScrollBars.Vertical;
            textBoxMessageMetxt.Size = new Size(1166, 749);
            textBoxMessageMetxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 273);
            label5.Name = "label5";
            label5.Size = new Size(192, 38);
            label5.TabIndex = 9;
            label5.Text = "Текст письма:";
            label5.Click += label5_Click;
            // 
            // checkBoxRUS
            // 
            checkBoxRUS.AutoSize = true;
            checkBoxRUS.Checked = true;
            checkBoxRUS.CheckState = CheckState.Checked;
            checkBoxRUS.Location = new Point(12, 1069);
            checkBoxRUS.Name = "checkBoxRUS";
            checkBoxRUS.Size = new Size(346, 42);
            checkBoxRUS.TabIndex = 10;
            checkBoxRUS.Text = "Текст на Русском языке";
            checkBoxRUS.UseVisualStyleBackColor = true;
            checkBoxRUS.CheckedChanged += checkBoxRUS_CheckedChanged;
            // 
            // checkBoxENG
            // 
            checkBoxENG.AutoSize = true;
            checkBoxENG.Location = new Point(364, 1069);
            checkBoxENG.Name = "checkBoxENG";
            checkBoxENG.Size = new Size(395, 42);
            checkBoxENG.TabIndex = 11;
            checkBoxENG.Text = "Текст на Английском языке";
            checkBoxENG.UseVisualStyleBackColor = true;
            checkBoxENG.CheckedChanged += checkBoxENG_CheckedChanged;
            // 
            // buttonCreateUserinAD
            // 
            buttonCreateUserinAD.Location = new Point(765, 1069);
            buttonCreateUserinAD.Name = "buttonCreateUserinAD";
            buttonCreateUserinAD.Size = new Size(413, 52);
            buttonCreateUserinAD.TabIndex = 12;
            buttonCreateUserinAD.Text = "Создать учетную запись ";
            buttonCreateUserinAD.UseVisualStyleBackColor = true;
            buttonCreateUserinAD.Click += buttonCreateUserinAD_Click;
            // 
            // PreviewCreateUsersAccountWithSendEmail
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 1123);
            Controls.Add(buttonCreateUserinAD);
            Controls.Add(checkBoxENG);
            Controls.Add(checkBoxRUS);
            Controls.Add(label5);
            Controls.Add(textBoxMessageMetxt);
            Controls.Add(textBoxListGroup);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxFrom);
            Controls.Add(textBoxTo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PreviewCreateUsersAccountWithSendEmail";
            Text = "PreviewCreateUsersAccountWithSendEmail";
            Load += PreviewCreateUsersAccountWithSendEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private TextBox textBoxSubject;
        private TextBox textBoxListGroup;
        private TextBox textBoxMessageMetxt;
        private Label label5;
        private CheckBox checkBoxRUS;
        private CheckBox checkBoxENG;
        private Button buttonCreateUserinAD;
    }
}