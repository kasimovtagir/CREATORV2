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
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 112);
            label11.Name = "label11";
            label11.Size = new Size(282, 32);
            label11.TabIndex = 33;
            label11.Text = "Добавить новую группу";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 693);
            label10.Name = "label10";
            label10.Size = new Size(0, 32);
            label10.TabIndex = 32;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(13, 295);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(1075, 376);
            listBox1.TabIndex = 31;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            comboBox2.Size = new Size(1074, 39);
            comboBox2.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 260);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 28;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(145, 32);
            label8.TabIndex = 27;
            label8.Text = "Выбери тип";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Сотрудник", "Студент", "Произвольный", "СУЗсПФ" });
            comboBox1.Location = new Point(12, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1076, 39);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 744);
            label1.Name = "label1";
            label1.Size = new Size(633, 32);
            label1.TabIndex = 34;
            label1.Text = "Для удаления группы, 2 раза нажми на группу в списке";
            // 
            // button2
            // 
            button2.Location = new Point(788, 696);
            button2.Name = "button2";
            button2.Size = new Size(298, 62);
            button2.TabIndex = 35;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListDefGroups
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 907);
            Controls.Add(button2);
            Controls.Add(label1);
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
            FormClosed += ListDefGroups_FormClosed;
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
        private Label label1;
        private Button button2;
    }
}