namespace CreatorV2
{
    partial class TextMessage
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
            textBoxSubject = new TextBox();
            textBoxText = new TextBox();
            checkBoxRussianText = new CheckBox();
            checkBoxENGText = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "Тема письма:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 1;
            label2.Text = "Текст письма";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(12, 44);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(1276, 45);
            textBoxSubject.TabIndex = 2;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(12, 127);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ScrollBars = ScrollBars.Both;
            textBoxText.Size = new Size(1276, 565);
            textBoxText.TabIndex = 3;
            // 
            // checkBoxRussianText
            // 
            checkBoxRussianText.AutoSize = true;
            checkBoxRussianText.Checked = true;
            checkBoxRussianText.CheckState = CheckState.Checked;
            checkBoxRussianText.Location = new Point(12, 692);
            checkBoxRussianText.Name = "checkBoxRussianText";
            checkBoxRussianText.Size = new Size(447, 42);
            checkBoxRussianText.TabIndex = 4;
            checkBoxRussianText.Text = "Текст письма на Русском языке";
            checkBoxRussianText.UseVisualStyleBackColor = true;
            checkBoxRussianText.CheckedChanged += checkBoxRussianText_CheckedChanged;
            // 
            // checkBoxENGText
            // 
            checkBoxENGText.AutoSize = true;
            checkBoxENGText.Location = new Point(465, 692);
            checkBoxENGText.Name = "checkBoxENGText";
            checkBoxENGText.Size = new Size(496, 42);
            checkBoxENGText.TabIndex = 5;
            checkBoxENGText.Text = "Текст письма на Английском языке";
            checkBoxENGText.UseVisualStyleBackColor = true;
            checkBoxENGText.CheckedChanged += checkBoxENGText_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(835, 731);
            button1.Name = "button1";
            button1.Size = new Size(453, 94);
            button1.TabIndex = 6;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 731);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // TextMessageRUS
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 835);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(checkBoxENGText);
            Controls.Add(checkBoxRussianText);
            Controls.Add(textBoxText);
            Controls.Add(textBoxSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "TextMessageRUS";
            Text = "TextMessage";
            Load += TextMessageRUS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxSubject;
        private TextBox textBoxText;
        private CheckBox checkBoxRussianText;
        private CheckBox checkBoxENGText;
        private Button button1;
        private Label label3;
    }
}