namespace CreatorV2
{
    partial class UploadListUserFromAllGroup
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
            progressBar = new ProgressBar();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 12);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(919, 73);
            progressBar.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(418, 91);
            button1.Name = "button1";
            button1.Size = new Size(154, 53);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 147);
            label1.Name = "label1";
            label1.Size = new Size(342, 21);
            label1.TabIndex = 2;
            label1.Text = "Нажми на кнопку START для запуска выгрузки";
            // 
            // UploadListUserFromAllGroup
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 180);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(progressBar);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UploadListUserFromAllGroup";
            Text = "UploadListUserFromAllGroup";
            FormClosed += UploadListUserFromAllGroup_FormClosed;
            Load += UploadListUserFromAllGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Button button1;
        private Label label1;
    }
}