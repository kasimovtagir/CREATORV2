namespace CreatorV2
{
    partial class DeleteGroup
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
            comboBoxListGroup = new ComboBox();
            buttonDeleteGroup = new Button();
            listBoxListChoosedGroup = new ListBox();
            label2 = new Label();
            buttonAddToList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 0;
            label1.Text = "Название группы";
            // 
            // comboBoxListGroup
            // 
            comboBoxListGroup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxListGroup.FormattingEnabled = true;
            comboBoxListGroup.Location = new Point(261, 13);
            comboBoxListGroup.Margin = new Padding(4);
            comboBoxListGroup.Name = "comboBoxListGroup";
            comboBoxListGroup.Size = new Size(422, 40);
            comboBoxListGroup.TabIndex = 1;
            // 
            // buttonDeleteGroup
            // 
            buttonDeleteGroup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteGroup.Location = new Point(496, 293);
            buttonDeleteGroup.Margin = new Padding(4);
            buttonDeleteGroup.Name = "buttonDeleteGroup";
            buttonDeleteGroup.Size = new Size(355, 63);
            buttonDeleteGroup.TabIndex = 2;
            buttonDeleteGroup.Text = "Удалить";
            buttonDeleteGroup.UseVisualStyleBackColor = true;
            buttonDeleteGroup.Click += buttonDeleteGroup_Click;
            // 
            // listBoxListChoosedGroup
            // 
            listBoxListChoosedGroup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListChoosedGroup.FormattingEnabled = true;
            listBoxListChoosedGroup.ItemHeight = 32;
            listBoxListChoosedGroup.Location = new Point(288, 58);
            listBoxListChoosedGroup.Name = "listBoxListChoosedGroup";
            listBoxListChoosedGroup.Size = new Size(563, 228);
            listBoxListChoosedGroup.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(269, 32);
            label2.TabIndex = 4;
            label2.Text = "Выбранные группы";
            // 
            // buttonAddToList
            // 
            buttonAddToList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddToList.Location = new Point(690, 12);
            buttonAddToList.Name = "buttonAddToList";
            buttonAddToList.Size = new Size(161, 40);
            buttonAddToList.TabIndex = 5;
            buttonAddToList.Text = "Добавить";
            buttonAddToList.UseVisualStyleBackColor = true;
            buttonAddToList.Click += buttonAddToList_Click;
            // 
            // DeleteGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 375);
            Controls.Add(buttonAddToList);
            Controls.Add(label2);
            Controls.Add(listBoxListChoosedGroup);
            Controls.Add(buttonDeleteGroup);
            Controls.Add(comboBoxListGroup);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "DeleteGroup";
            Text = "DeleteGroup";
            FormClosing += DeleteGroup_FormClosing;
            Load += DeleteGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxListGroup;
        private Button buttonDeleteGroup;
        private ListBox listBoxListChoosedGroup;
        private Label label2;
        private Button buttonAddToList;
    }
}