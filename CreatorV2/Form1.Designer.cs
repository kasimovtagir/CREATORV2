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
            парольДляПользователяToolStripMenuItem = new ToolStripMenuItem();
            добавитьПользователяВГруппуToolStripMenuItem = new ToolStripMenuItem();
            одинаныйToolStripMenuItem = new ToolStripMenuItem();
            множественныйToolStripMenuItem = new ToolStripMenuItem();
            работаСГруппамиToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxUserNameInAD = new TextBox();
            textBoxLastNameInAD = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            textBoxThirdName = new TextBox();
            textBoxISUID = new TextBox();
            textBoxDescription = new TextBox();
            textBoxEMAIL = new TextBox();
            textBoxPassword = new TextBox();
            label10 = new Label();
            comboBoxTypePost = new ComboBox();
            checkBoxWinthEmail = new CheckBox();
            buttonCreateUser = new Button();
            listBox1 = new ListBox();
            создатьГруппуToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1266, 42);
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
            группыПоУмолчаниюToolStripMenuItem.Click += группыПоУмолчаниюToolStripMenuItem_Click;
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
            работаСПользователямиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { парольДляПользователяToolStripMenuItem, добавитьПользователяВГруппуToolStripMenuItem });
            работаСПользователямиToolStripMenuItem.Name = "работаСПользователямиToolStripMenuItem";
            работаСПользователямиToolStripMenuItem.Size = new Size(310, 36);
            работаСПользователямиToolStripMenuItem.Text = "Работа с пользователями";
            // 
            // парольДляПользователяToolStripMenuItem
            // 
            парольДляПользователяToolStripMenuItem.Name = "парольДляПользователяToolStripMenuItem";
            парольДляПользователяToolStripMenuItem.Size = new Size(468, 36);
            парольДляПользователяToolStripMenuItem.Text = "Пароль для пользователя";
            парольДляПользователяToolStripMenuItem.Click += парольДляПользователяToolStripMenuItem_Click;
            // 
            // добавитьПользователяВГруппуToolStripMenuItem
            // 
            добавитьПользователяВГруппуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одинаныйToolStripMenuItem, множественныйToolStripMenuItem });
            добавитьПользователяВГруппуToolStripMenuItem.Name = "добавитьПользователяВГруппуToolStripMenuItem";
            добавитьПользователяВГруппуToolStripMenuItem.Size = new Size(468, 36);
            добавитьПользователяВГруппуToolStripMenuItem.Text = "Добавить пользователя в группу";
            добавитьПользователяВГруппуToolStripMenuItem.Click += добавитьПользователяВГруппуToolStripMenuItem_Click;
            // 
            // одинаныйToolStripMenuItem
            // 
            одинаныйToolStripMenuItem.Name = "одинаныйToolStripMenuItem";
            одинаныйToolStripMenuItem.Size = new Size(289, 36);
            одинаныйToolStripMenuItem.Text = "Одинарный";
            одинаныйToolStripMenuItem.Click += одинаныйToolStripMenuItem_Click;
            // 
            // множественныйToolStripMenuItem
            // 
            множественныйToolStripMenuItem.Name = "множественныйToolStripMenuItem";
            множественныйToolStripMenuItem.Size = new Size(289, 36);
            множественныйToolStripMenuItem.Text = "Множественный";
            // 
            // работаСГруппамиToolStripMenuItem
            // 
            работаСГруппамиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьГруппуToolStripMenuItem });
            работаСГруппамиToolStripMenuItem.Name = "работаСГруппамиToolStripMenuItem";
            работаСГруппамиToolStripMenuItem.Size = new Size(234, 36);
            работаСГруппамиToolStripMenuItem.Text = "Работа с группами";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Имя в AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 2;
            label2.Text = "Фамилия в AD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 3;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 4;
            label4.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 258);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 5;
            label5.Text = "Отчество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 309);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 6;
            label6.Text = "ISU ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 360);
            label7.Name = "label7";
            label7.Size = new Size(124, 32);
            label7.TabIndex = 7;
            label7.Text = "Описание";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 411);
            label8.Name = "label8";
            label8.Size = new Size(118, 32);
            label8.TabIndex = 8;
            label8.Text = "Эл. почта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 462);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 9;
            label9.Text = "Пароль";
            // 
            // textBoxUserNameInAD
            // 
            textBoxUserNameInAD.Location = new Point(219, 103);
            textBoxUserNameInAD.Name = "textBoxUserNameInAD";
            textBoxUserNameInAD.Size = new Size(375, 39);
            textBoxUserNameInAD.TabIndex = 11;
            // 
            // textBoxLastNameInAD
            // 
            textBoxLastNameInAD.Location = new Point(219, 51);
            textBoxLastNameInAD.Name = "textBoxLastNameInAD";
            textBoxLastNameInAD.Size = new Size(375, 39);
            textBoxLastNameInAD.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(219, 153);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(375, 39);
            textBoxLastName.TabIndex = 13;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(219, 204);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(375, 39);
            textBoxName.TabIndex = 14;
            // 
            // textBoxThirdName
            // 
            textBoxThirdName.Location = new Point(219, 255);
            textBoxThirdName.Name = "textBoxThirdName";
            textBoxThirdName.Size = new Size(375, 39);
            textBoxThirdName.TabIndex = 15;
            // 
            // textBoxISUID
            // 
            textBoxISUID.Location = new Point(219, 306);
            textBoxISUID.Name = "textBoxISUID";
            textBoxISUID.Size = new Size(375, 39);
            textBoxISUID.TabIndex = 16;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(219, 357);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(375, 39);
            textBoxDescription.TabIndex = 17;
            // 
            // textBoxEMAIL
            // 
            textBoxEMAIL.Location = new Point(219, 408);
            textBoxEMAIL.Name = "textBoxEMAIL";
            textBoxEMAIL.Size = new Size(375, 39);
            textBoxEMAIL.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(219, 459);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(375, 39);
            textBoxPassword.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 513);
            label10.Name = "label10";
            label10.Size = new Size(137, 32);
            label10.TabIndex = 20;
            label10.Text = "Должность";
            // 
            // comboBoxTypePost
            // 
            comboBoxTypePost.FormattingEnabled = true;
            comboBoxTypePost.Items.AddRange(new object[] { "Сотрудник", "Студент" });
            comboBoxTypePost.Location = new Point(219, 510);
            comboBoxTypePost.Name = "comboBoxTypePost";
            comboBoxTypePost.Size = new Size(375, 39);
            comboBoxTypePost.TabIndex = 21;
            // 
            // checkBoxWinthEmail
            // 
            checkBoxWinthEmail.AutoSize = true;
            checkBoxWinthEmail.Checked = true;
            checkBoxWinthEmail.CheckState = CheckState.Checked;
            checkBoxWinthEmail.Location = new Point(83, 562);
            checkBoxWinthEmail.Name = "checkBoxWinthEmail";
            checkBoxWinthEmail.Size = new Size(372, 36);
            checkBoxWinthEmail.TabIndex = 22;
            checkBoxWinthEmail.Text = "Отравить письмо на Эл. почту";
            checkBoxWinthEmail.UseVisualStyleBackColor = true;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(12, 618);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(347, 68);
            buttonCreateUser.TabIndex = 23;
            buttonCreateUser.Text = "Создать учетную запись";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(600, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(654, 593);
            listBox1.TabIndex = 24;
            // 
            // создатьГруппуToolStripMenuItem
            // 
            создатьГруппуToolStripMenuItem.Name = "создатьГруппуToolStripMenuItem";
            создатьГруппуToolStripMenuItem.Size = new Size(271, 36);
            создатьГруппуToolStripMenuItem.Text = "Создать группу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 698);
            Controls.Add(listBox1);
            Controls.Add(buttonCreateUser);
            Controls.Add(checkBoxWinthEmail);
            Controls.Add(comboBoxTypePost);
            Controls.Add(label10);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEMAIL);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxISUID);
            Controls.Add(textBoxThirdName);
            Controls.Add(textBoxName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxLastNameInAD);
            Controls.Add(textBoxUserNameInAD);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "CREATOR V 2";
            Load += Form1_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxUserNameInAD;
        private TextBox textBoxLastNameInAD;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private TextBox textBoxThirdName;
        private TextBox textBoxISUID;
        private TextBox textBoxDescription;
        private TextBox textBoxEMAIL;
        private TextBox textBoxPassword;
        private Label label10;
        private ComboBox comboBoxTypePost;
        private CheckBox checkBoxWinthEmail;
        private Button buttonCreateUser;
        private ToolStripMenuItem парольДляПользователяToolStripMenuItem;
        private ListBox listBox1;
        private ToolStripMenuItem добавитьПользователяВГруппуToolStripMenuItem;
        private ToolStripMenuItem одинаныйToolStripMenuItem;
        private ToolStripMenuItem множественныйToolStripMenuItem;
        private ToolStripMenuItem создатьГруппуToolStripMenuItem;
    }
}