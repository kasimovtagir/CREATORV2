namespace CreatorV2
{
    partial class SUZsPF
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            comboBoxListOU = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxTypePost = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(18, 18);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(490, 52);
            button1.TabIndex = 0;
            button1.Text = "Выбери файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(518, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(170, 948);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(741, 144);
            button2.TabIndex = 2;
            button2.Text = "Создать учетные записи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 80);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1074, 725);
            dataGridView1.TabIndex = 3;
            // 
            // comboBoxListOU
            // 
            comboBoxListOU.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListOU.FormattingEnabled = true;
            comboBoxListOU.Location = new Point(97, 894);
            comboBoxListOU.Name = "comboBoxListOU";
            comboBoxListOU.Size = new Size(995, 46);
            comboBoxListOU.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 897);
            label2.Name = "label2";
            label2.Size = new Size(73, 38);
            label2.TabIndex = 5;
            label2.Text = "Ou=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 836);
            label3.Name = "label3";
            label3.Size = new Size(158, 38);
            label3.TabIndex = 6;
            label3.Text = "Должность";
            // 
            // comboBoxTypePost
            // 
            comboBoxTypePost.FormattingEnabled = true;
            comboBoxTypePost.Items.AddRange(new object[] { "Сотрудник", "Студент", "Произвольный" });
            comboBoxTypePost.Location = new Point(182, 833);
            comboBoxTypePost.Name = "comboBoxTypePost";
            comboBoxTypePost.Size = new Size(910, 46);
            comboBoxTypePost.TabIndex = 22;
            // 
            // SUZsPF
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 1108);
            Controls.Add(comboBoxTypePost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxListOU);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SUZsPF";
            Text = "SUZsPF";
            Load += SUZsPF_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView1;
        private ComboBox comboBoxListOU;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxTypePost;
    }
}