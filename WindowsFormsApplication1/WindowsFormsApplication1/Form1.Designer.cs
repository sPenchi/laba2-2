namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Laba = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.T2_textBox1 = new System.Windows.Forms.TextBox();
            this.T2_textBox2 = new System.Windows.Forms.TextBox();
            this.T2_textBox3 = new System.Windows.Forms.TextBox();
            this.T2_button1 = new System.Windows.Forms.Button();
            this.T2_button2 = new System.Windows.Forms.Button();
            this.T2_button3 = new System.Windows.Forms.Button();
            this.T2_button4 = new System.Windows.Forms.Button();
            this.T2_button5 = new System.Windows.Forms.Button();
            this.T2_button6 = new System.Windows.Forms.Button();
            this.t1_label1 = new System.Windows.Forms.Label();
            this.t1_label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Laba.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Laba
            // 
            this.Laba.Controls.Add(this.tabPage1);
            this.Laba.Controls.Add(this.tabPage2);
            this.Laba.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Laba.Location = new System.Drawing.Point(12, 12);
            this.Laba.Name = "Laba";
            this.Laba.SelectedIndex = 0;
            this.Laba.Size = new System.Drawing.Size(888, 508);
            this.Laba.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.t1_label2);
            this.tabPage1.Controls.Add(this.t1_label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Приветствие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.T2_button6);
            this.tabPage2.Controls.Add(this.T2_button5);
            this.tabPage2.Controls.Add(this.T2_button4);
            this.tabPage2.Controls.Add(this.T2_button3);
            this.tabPage2.Controls.Add(this.T2_button2);
            this.tabPage2.Controls.Add(this.T2_button1);
            this.tabPage2.Controls.Add(this.T2_textBox3);
            this.tabPage2.Controls.Add(this.T2_textBox2);
            this.tabPage2.Controls.Add(this.T2_textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калькулятор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // T2_textBox1
            // 
            this.T2_textBox1.Location = new System.Drawing.Point(70, 55);
            this.T2_textBox1.Name = "T2_textBox1";
            this.T2_textBox1.Size = new System.Drawing.Size(141, 20);
            this.T2_textBox1.TabIndex = 0;
            // 
            // T2_textBox2
            // 
            this.T2_textBox2.Location = new System.Drawing.Point(333, 55);
            this.T2_textBox2.Name = "T2_textBox2";
            this.T2_textBox2.Size = new System.Drawing.Size(139, 20);
            this.T2_textBox2.TabIndex = 1;
            // 
            // T2_textBox3
            // 
            this.T2_textBox3.Location = new System.Drawing.Point(138, 403);
            this.T2_textBox3.Name = "T2_textBox3";
            this.T2_textBox3.Size = new System.Drawing.Size(262, 20);
            this.T2_textBox3.TabIndex = 2;
            // 
            // T2_button1
            // 
            this.T2_button1.Location = new System.Drawing.Point(104, 136);
            this.T2_button1.Name = "T2_button1";
            this.T2_button1.Size = new System.Drawing.Size(75, 23);
            this.T2_button1.TabIndex = 4;
            this.T2_button1.Text = "Сложение";
            this.T2_button1.UseVisualStyleBackColor = true;
            this.T2_button1.Click += new System.EventHandler(this.T2_button1_Click);
            // 
            // T2_button2
            // 
            this.T2_button2.Location = new System.Drawing.Point(104, 217);
            this.T2_button2.Name = "T2_button2";
            this.T2_button2.Size = new System.Drawing.Size(75, 23);
            this.T2_button2.TabIndex = 5;
            this.T2_button2.Text = "Вычитание";
            this.T2_button2.UseVisualStyleBackColor = true;
            this.T2_button2.Click += new System.EventHandler(this.T2_button2_Click);
            // 
            // T2_button3
            // 
            this.T2_button3.Location = new System.Drawing.Point(104, 300);
            this.T2_button3.Name = "T2_button3";
            this.T2_button3.Size = new System.Drawing.Size(75, 22);
            this.T2_button3.TabIndex = 6;
            this.T2_button3.Text = "В степень";
            this.T2_button3.UseVisualStyleBackColor = true;
            this.T2_button3.Click += new System.EventHandler(this.T2_button3_Click);
            // 
            // T2_button4
            // 
            this.T2_button4.Location = new System.Drawing.Point(367, 136);
            this.T2_button4.Name = "T2_button4";
            this.T2_button4.Size = new System.Drawing.Size(75, 23);
            this.T2_button4.TabIndex = 7;
            this.T2_button4.Text = "Умножение";
            this.T2_button4.UseVisualStyleBackColor = true;
            this.T2_button4.Click += new System.EventHandler(this.T2_button4_Click);
            // 
            // T2_button5
            // 
            this.T2_button5.Location = new System.Drawing.Point(367, 217);
            this.T2_button5.Name = "T2_button5";
            this.T2_button5.Size = new System.Drawing.Size(75, 23);
            this.T2_button5.TabIndex = 8;
            this.T2_button5.Text = "Деление";
            this.T2_button5.UseVisualStyleBackColor = true;
            this.T2_button5.Click += new System.EventHandler(this.T2_button5_Click);
            // 
            // T2_button6
            // 
            this.T2_button6.Location = new System.Drawing.Point(367, 300);
            this.T2_button6.Name = "T2_button6";
            this.T2_button6.Size = new System.Drawing.Size(75, 23);
            this.T2_button6.TabIndex = 9;
            this.T2_button6.Text = "Корень";
            this.T2_button6.UseVisualStyleBackColor = true;
            this.T2_button6.Click += new System.EventHandler(this.T2_button6_Click);
            // 
            // t1_label1
            // 
            this.t1_label1.AutoSize = true;
            this.t1_label1.Location = new System.Drawing.Point(60, 191);
            this.t1_label1.Name = "t1_label1";
            this.t1_label1.Size = new System.Drawing.Size(35, 13);
            this.t1_label1.TabIndex = 0;
            this.t1_label1.Text = "Name";
            // 
            // t1_label2
            // 
            this.t1_label2.AutoSize = true;
            this.t1_label2.Location = new System.Drawing.Point(60, 54);
            this.t1_label2.Name = "t1_label2";
            this.t1_label2.Size = new System.Drawing.Size(110, 13);
            this.t1_label2.TabIndex = 1;
            this.t1_label2.Text = "Напишите ваше имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 606);
            this.Controls.Add(this.Laba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Laba.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Laba;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button T2_button6;
        private System.Windows.Forms.Button T2_button5;
        private System.Windows.Forms.Button T2_button4;
        private System.Windows.Forms.Button T2_button3;
        private System.Windows.Forms.Button T2_button2;
        private System.Windows.Forms.Button T2_button1;
        private System.Windows.Forms.TextBox T2_textBox3;
        private System.Windows.Forms.TextBox T2_textBox2;
        private System.Windows.Forms.TextBox T2_textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label t1_label2;
        private System.Windows.Forms.Label t1_label1;
    }
}

