namespace rsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_p = new System.Windows.Forms.MaskedTextBox();
            this.textbox_q = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.in_encrypt_textbox = new System.Windows.Forms.TextBox();
            this.out_encrypt_textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_n = new System.Windows.Forms.MaskedTextBox();
            this.textbox_d = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.out_decrypt_textBox = new System.Windows.Forms.TextBox();
            this.in_decrypt_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "p =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(154, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "q =";
            // 
            // textbox_p
            // 
            this.textbox_p.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textbox_p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_p.ForeColor = System.Drawing.Color.Transparent;
            this.textbox_p.Location = new System.Drawing.Point(44, 32);
            this.textbox_p.Mask = "00000";
            this.textbox_p.Name = "textbox_p";
            this.textbox_p.Size = new System.Drawing.Size(100, 15);
            this.textbox_p.TabIndex = 4;
            this.textbox_p.ValidatingType = typeof(int);
            // 
            // textbox_q
            // 
            this.textbox_q.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textbox_q.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_q.ForeColor = System.Drawing.Color.Transparent;
            this.textbox_q.Location = new System.Drawing.Point(185, 32);
            this.textbox_q.Mask = "00000";
            this.textbox_q.Name = "textbox_q";
            this.textbox_q.Size = new System.Drawing.Size(100, 15);
            this.textbox_q.TabIndex = 5;
            this.textbox_q.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(69, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // in_encrypt_textbox
            // 
            this.in_encrypt_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.in_encrypt_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.in_encrypt_textbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.in_encrypt_textbox.Location = new System.Drawing.Point(324, 32);
            this.in_encrypt_textbox.Multiline = true;
            this.in_encrypt_textbox.Name = "in_encrypt_textbox";
            this.in_encrypt_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.in_encrypt_textbox.Size = new System.Drawing.Size(206, 110);
            this.in_encrypt_textbox.TabIndex = 7;
            // 
            // out_encrypt_textbox
            // 
            this.out_encrypt_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.out_encrypt_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out_encrypt_textbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.out_encrypt_textbox.Location = new System.Drawing.Point(554, 32);
            this.out_encrypt_textbox.Name = "out_encrypt_textbox";
            this.out_encrypt_textbox.Size = new System.Drawing.Size(199, 15);
            this.out_encrypt_textbox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(69, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textbox_n
            // 
            this.textbox_n.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textbox_n.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_n.ForeColor = System.Drawing.Color.Transparent;
            this.textbox_n.Location = new System.Drawing.Point(196, 226);
            this.textbox_n.Mask = "00000";
            this.textbox_n.Name = "textbox_n";
            this.textbox_n.Size = new System.Drawing.Size(100, 15);
            this.textbox_n.TabIndex = 12;
            this.textbox_n.ValidatingType = typeof(int);
            // 
            // textbox_d
            // 
            this.textbox_d.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textbox_d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_d.ForeColor = System.Drawing.Color.Transparent;
            this.textbox_d.Location = new System.Drawing.Point(44, 226);
            this.textbox_d.Mask = "00000";
            this.textbox_d.Name = "textbox_d";
            this.textbox_d.Size = new System.Drawing.Size(100, 15);
            this.textbox_d.TabIndex = 11;
            this.textbox_d.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(165, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "n =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "d =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "OUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "OUT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(321, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "IN";
            // 
            // out_decrypt_textBox
            // 
            this.out_decrypt_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.out_decrypt_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out_decrypt_textBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.out_decrypt_textBox.Location = new System.Drawing.Point(544, 31);
            this.out_decrypt_textBox.Multiline = true;
            this.out_decrypt_textBox.Name = "out_decrypt_textBox";
            this.out_decrypt_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.out_decrypt_textBox.Size = new System.Drawing.Size(206, 110);
            this.out_decrypt_textBox.TabIndex = 17;
            // 
            // in_decrypt_textbox
            // 
            this.in_decrypt_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.in_decrypt_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.in_decrypt_textbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.in_decrypt_textbox.Location = new System.Drawing.Point(324, 30);
            this.in_decrypt_textbox.Name = "in_decrypt_textbox";
            this.in_decrypt_textbox.Size = new System.Drawing.Size(206, 15);
            this.in_decrypt_textbox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.in_encrypt_textbox);
            this.groupBox1.Controls.Add(this.out_encrypt_textbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textbox_p);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 190);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифровка";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.out_decrypt_textBox);
            this.groupBox2.Controls.Add(this.in_decrypt_textbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(0, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифровка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.textbox_n);
            this.Controls.Add(this.textbox_d);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Form1";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textbox_p;
        private System.Windows.Forms.MaskedTextBox textbox_q;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox in_encrypt_textbox;
        private System.Windows.Forms.TextBox out_encrypt_textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox textbox_n;
        private System.Windows.Forms.MaskedTextBox textbox_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox out_decrypt_textBox;
        private System.Windows.Forms.TextBox in_decrypt_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

