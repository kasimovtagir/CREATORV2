namespace CreatorV2
{
    partial class ListDefGroups
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
            label11 = new Label();
            label10 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 112);
            label11.Name = "label11";
            label11.Size = new Size(325, 38);
            label11.TabIndex = 33;
            label11.Text = "Добавить новую группу";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 693);
            label10.Name = "label10";
            label10.Size = new Size(732, 38);
            label10.TabIndex = 32;
            label10.Text = "Для удаления группы, 2 раза нажми на группу в списке";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(13, 295);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(1075, 384);
            listBox1.TabIndex = 31;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 205);
            button1.Name = "button1";
            button1.Size = new Size(1076, 52);
            button1.TabIndex = 30;
            button1.Text = "Добавить в группу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(1074, 46);
            comboBox2.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 260);
            label9.Name = "label9";
            label9.Size = new Size(91, 38);
            label9.TabIndex = 28;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(167, 38);
            label8.TabIndex = 27;
            label8.Text = "Выбери тип";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Сотрудник", "Студент", "Произвольный", "СУЗсПФ" });
            comboBox1.Location = new Point(12, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1076, 46);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ListDefGroups
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 748);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListDefGroups";
            Text = "ListDefGropus";
            Load += ListDefGropus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label10;
        private ListBox listBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label9;
        private Label label8;
        private ComboBox comboBox1;
    }
}