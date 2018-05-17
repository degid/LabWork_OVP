namespace LabWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Close = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_newText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_del = new System.Windows.Forms.RadioButton();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ChandeColorOff = new System.Windows.Forms.RadioButton();
            this.radioButton_ChandeColorOn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(173, 262);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Выход";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox_newText
            // 
            this.textBox_newText.Location = new System.Drawing.Point(106, 27);
            this.textBox_newText.Name = "textBox_newText";
            this.textBox_newText.Size = new System.Drawing.Size(118, 20);
            this.textBox_newText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton_del);
            this.groupBox1.Controls.Add(this.radioButton_add);
            this.groupBox1.Controls.Add(this.textBox_newText);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действие";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Очистить";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_del
            // 
            this.radioButton_del.AutoSize = true;
            this.radioButton_del.Location = new System.Drawing.Point(17, 52);
            this.radioButton_del.Name = "radioButton_del";
            this.radioButton_del.Size = new System.Drawing.Size(68, 17);
            this.radioButton_del.TabIndex = 3;
            this.radioButton_del.Text = "Удалить";
            this.radioButton_del.UseVisualStyleBackColor = true;
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.Checked = true;
            this.radioButton_add.Location = new System.Drawing.Point(17, 28);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(75, 17);
            this.radioButton_add.TabIndex = 1;
            this.radioButton_add.TabStop = true;
            this.radioButton_add.Text = "Добавить";
            this.radioButton_add.UseVisualStyleBackColor = true;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(6, 19);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(218, 21);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxColor_DrawItem);
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_ChandeColorOff);
            this.groupBox2.Controls.Add(this.radioButton_ChandeColorOn);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить цвет comboBox";
            // 
            // radioButton_ChandeColorOff
            // 
            this.radioButton_ChandeColorOff.AutoSize = true;
            this.radioButton_ChandeColorOff.Location = new System.Drawing.Point(17, 71);
            this.radioButton_ChandeColorOff.Name = "radioButton_ChandeColorOff";
            this.radioButton_ChandeColorOff.Size = new System.Drawing.Size(82, 17);
            this.radioButton_ChandeColorOff.TabIndex = 6;
            this.radioButton_ChandeColorOff.Text = "Выключить";
            this.radioButton_ChandeColorOff.UseVisualStyleBackColor = true;
            // 
            // radioButton_ChandeColorOn
            // 
            this.radioButton_ChandeColorOn.AutoSize = true;
            this.radioButton_ChandeColorOn.Checked = true;
            this.radioButton_ChandeColorOn.Location = new System.Drawing.Point(17, 47);
            this.radioButton_ChandeColorOn.Name = "radioButton_ChandeColorOn";
            this.radioButton_ChandeColorOn.Size = new System.Drawing.Size(74, 17);
            this.radioButton_ChandeColorOn.TabIndex = 5;
            this.radioButton_ChandeColorOn.TabStop = true;
            this.radioButton_ChandeColorOn.Text = "Включить";
            this.radioButton_ChandeColorOn.UseVisualStyleBackColor = true;
            this.radioButton_ChandeColorOn.CheckedChanged += new System.EventHandler(this.radioButton_ChandeColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Close);
            this.MinimumSize = new System.Drawing.Size(276, 335);
            this.Name = "Form1";
            this.Text = "Лабораторная работа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_newText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_del;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_ChandeColorOff;
        private System.Windows.Forms.RadioButton radioButton_ChandeColorOn;
    }
}

