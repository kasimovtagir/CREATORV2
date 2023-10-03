namespace CreatorV2
{
    partial class DomainSettings
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
            buttonSaveNetBios = new Button();
            textBoxNetBios = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonSaveNetBios
            // 
            buttonSaveNetBios.Location = new Point(12, 57);
            buttonSaveNetBios.Name = "buttonSaveNetBios";
            buttonSaveNetBios.Size = new Size(597, 125);
            buttonSaveNetBios.TabIndex = 0;
            buttonSaveNetBios.Text = "Сохранить";
            buttonSaveNetBios.UseVisualStyleBackColor = true;
            buttonSaveNetBios.Click += buttonSaveNetBios_Click;
            // 
            // textBoxNetBios
            // 
            textBoxNetBios.Location = new Point(126, 12);
            textBoxNetBios.Name = "textBoxNetBios";
            textBoxNetBios.Size = new Size(483, 39);
            textBoxNetBios.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 2;
            label1.Text = "NETBIOS";
            // 
            // DomainSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 209);
            Controls.Add(label1);
            Controls.Add(textBoxNetBios);
            Controls.Add(buttonSaveNetBios);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "DomainSettings";
            Text = "Настройки домена";
            Load += DomainSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveNetBios;
        private TextBox textBoxNetBios;
        private Label label1;
    }
}