namespace CreatorV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            аккаунтДляОтправкиEmailToolStripMenuItem = new ToolStripMenuItem();
            текстПисьмаToolStripMenuItem = new ToolStripMenuItem();
            группыПоУмолчаниюToolStripMenuItem = new ToolStripMenuItem();
            доменToolStripMenuItem = new ToolStripMenuItem();
            текстПисьмаToolStripMenuItem1 = new ToolStripMenuItem();
            работаСПользователямиToolStripMenuItem = new ToolStripMenuItem();
            работаСГруппамиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, работаСПользователямиToolStripMenuItem, работаСГруппамиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1300, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { аккаунтДляОтправкиEmailToolStripMenuItem, текстПисьмаToolStripMenuItem, группыПоУмолчаниюToolStripMenuItem, доменToolStripMenuItem, текстПисьмаToolStripMenuItem1 });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(146, 36);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // аккаунтДляОтправкиEmailToolStripMenuItem
            // 
            аккаунтДляОтправкиEmailToolStripMenuItem.Name = "аккаунтДляОтправкиEmailToolStripMenuItem";
            аккаунтДляОтправкиEmailToolStripMenuItem.Size = new Size(409, 36);
            аккаунтДляОтправкиEmailToolStripMenuItem.Text = "Аккаунт для отправки email";
            аккаунтДляОтправкиEmailToolStripMenuItem.Click += аккаунтДляОтправкиEmailToolStripMenuItem_Click;
            // 
            // текстПисьмаToolStripMenuItem
            // 
            текстПисьмаToolStripMenuItem.Name = "текстПисьмаToolStripMenuItem";
            текстПисьмаToolStripMenuItem.Size = new Size(409, 36);
            текстПисьмаToolStripMenuItem.Text = "Текст письма";
            текстПисьмаToolStripMenuItem.Click += текстПисьмаToolStripMenuItem_Click;
            // 
            // группыПоУмолчаниюToolStripMenuItem
            // 
            группыПоУмолчаниюToolStripMenuItem.Name = "группыПоУмолчаниюToolStripMenuItem";
            группыПоУмолчаниюToolStripMenuItem.Size = new Size(409, 36);
            группыПоУмолчаниюToolStripMenuItem.Text = "Группы по умолчанию";
            // 
            // доменToolStripMenuItem
            // 
            доменToolStripMenuItem.Name = "доменToolStripMenuItem";
            доменToolStripMenuItem.Size = new Size(409, 36);
            доменToolStripMenuItem.Text = "Домен";
            доменToolStripMenuItem.Click += доменToolStripMenuItem_Click;
            // 
            // текстПисьмаToolStripMenuItem1
            // 
            текстПисьмаToolStripMenuItem1.Name = "текстПисьмаToolStripMenuItem1";
            текстПисьмаToolStripMenuItem1.Size = new Size(409, 36);
            текстПисьмаToolStripMenuItem1.Text = "Текст письма";
            // 
            // работаСПользователямиToolStripMenuItem
            // 
            работаСПользователямиToolStripMenuItem.Name = "работаСПользователямиToolStripMenuItem";
            работаСПользователямиToolStripMenuItem.Size = new Size(310, 36);
            работаСПользователямиToolStripMenuItem.Text = "Работа с пользователями";
            // 
            // работаСГруппамиToolStripMenuItem
            // 
            работаСГруппамиToolStripMenuItem.Name = "работаСГруппамиToolStripMenuItem";
            работаСГруппамиToolStripMenuItem.Size = new Size(234, 36);
            работаСГруппамиToolStripMenuItem.Text = "Работа с группами";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "CREATOR V 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem аккаунтДляОтправкиEmailToolStripMenuItem;
        private ToolStripMenuItem текстПисьмаToolStripMenuItem;
        private ToolStripMenuItem группыПоУмолчаниюToolStripMenuItem;
        private ToolStripMenuItem работаСПользователямиToolStripMenuItem;
        private ToolStripMenuItem работаСГруппамиToolStripMenuItem;
        private ToolStripMenuItem доменToolStripMenuItem;
        private ToolStripMenuItem текстПисьмаToolStripMenuItem1;
    }
}