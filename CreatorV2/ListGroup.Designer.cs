namespace CreatorV2
{
    partial class ListGroup
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
            buttonSaveSettingsListGroup = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // buttonSaveSettingsListGroup
            // 
            buttonSaveSettingsListGroup.Location = new Point(13, 724);
            buttonSaveSettingsListGroup.Margin = new Padding(4, 5, 4, 5);
            buttonSaveSettingsListGroup.Name = "buttonSaveSettingsListGroup";
            buttonSaveSettingsListGroup.Size = new Size(298, 56);
            buttonSaveSettingsListGroup.TabIndex = 0;
            buttonSaveSettingsListGroup.Text = "Сохранить";
            buttonSaveSettingsListGroup.UseVisualStyleBackColor = true;
            buttonSaveSettingsListGroup.Click += buttonSaveSettingsListGroup_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Сотрудник", "Студент", "Произвольный", "СУЗсПФ" });
            comboBox1.Location = new Point(12, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(422, 46);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(167, 38);
            label8.TabIndex = 18;
            label8.Text = "Выбери тип";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 254);
            label9.Name = "label9";
            label9.Size = new Size(91, 38);
            label9.TabIndex = 19;
            label9.Text = "label9";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(14, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(420, 46);
            comboBox2.TabIndex = 20;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 186);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 21;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(13, 289);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(421, 384);
            listBox1.TabIndex = 22;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 687);
            label10.Name = "label10";
            label10.Size = new Size(106, 38);
            label10.TabIndex = 23;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 93);
            label11.Name = "label11";
            label11.Size = new Size(325, 38);
            label11.TabIndex = 24;
            label11.Text = "Добавить новую группу";
            // 
            // ListGroup
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 856);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(buttonSaveSettingsListGroup);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListGroup";
            Text = "ListGroup";
            Load += ListGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveSettingsListGroup;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private ComboBox comboBox2;
        private Button button1;
        private ListBox listBox1;
        private Label label10;
        private Label label11;
    }
}