namespace CreatorV2
{
    partial class EmployeeCard
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
            comboBoxUserName = new ComboBox();
            buttonShowEmployeeCard = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 13);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя";
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(574, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(424, 46);
            comboBoxUserName.TabIndex = 1;
            // 
            // buttonShowEmployeeCard
            // 
            buttonShowEmployeeCard.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowEmployeeCard.Location = new Point(753, 64);
            buttonShowEmployeeCard.Name = "buttonShowEmployeeCard";
            buttonShowEmployeeCard.Size = new Size(245, 57);
            buttonShowEmployeeCard.TabIndex = 2;
            buttonShowEmployeeCard.Text = "Показать";
            buttonShowEmployeeCard.UseVisualStyleBackColor = true;
            buttonShowEmployeeCard.Click += buttonShowEmployeeCard_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 229);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1470, 429);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 4;
            label2.Text = "Список групп";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(1341, 82);
            textBox1.TabIndex = 5;
            // 
            // EmployeeCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 669);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(buttonShowEmployeeCard);
            Controls.Add(comboBoxUserName);
            Controls.Add(label1);
            Name = "EmployeeCard";
            Text = "EmployeeCard";
            FormClosing += EmployeeCard_FormClosing;
            Load += EmployeeCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxUserName;
        private Button buttonShowEmployeeCard;
        private ListBox listBox1;
        private Label label2;
        private TextBox textBox1;
    }
}