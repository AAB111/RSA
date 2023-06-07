namespace rsa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.out_encrypt_textbox = new System.Windows.Forms.TextBox();
            this.in_encrypt_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_q = new System.Windows.Forms.MaskedTextBox();
            this.textbox_p = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.in_decrypt_textbox = new System.Windows.Forms.TextBox();
            this.textbox_n = new System.Windows.Forms.MaskedTextBox();
            this.out_decrypt_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_d = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.out_encrypt_textbox);
            this.groupBox1.Controls.Add(this.in_encrypt_textbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textbox_q);
            this.groupBox1.Controls.Add(this.textbox_p);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зашифровать";
            // 
            // out_encrypt_textbox
            // 
            this.out_encrypt_textbox.Location = new System.Drawing.Point(625, 70);
            this.out_encrypt_textbox.Name = "out_encrypt_textbox";
            this.out_encrypt_textbox.Size = new System.Drawing.Size(150, 22);
            this.out_encrypt_textbox.TabIndex = 18;
            // 
            // in_encrypt_textbox
            // 
            this.in_encrypt_textbox.Location = new System.Drawing.Point(431, 70);
            this.in_encrypt_textbox.Multiline = true;
            this.in_encrypt_textbox.Name = "in_encrypt_textbox";
            this.in_encrypt_textbox.Size = new System.Drawing.Size(150, 112);
            this.in_encrypt_textbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "OUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "IN";
            // 
            // textbox_q
            // 
            this.textbox_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_q.Location = new System.Drawing.Point(199, 42);
            this.textbox_q.Mask = resources.GetString("textbox_q.Mask");
            this.textbox_q.Name = "textbox_q";
            this.textbox_q.Size = new System.Drawing.Size(100, 22);
            this.textbox_q.TabIndex = 9;
            // 
            // textbox_p
            // 
            this.textbox_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_p.Location = new System.Drawing.Point(44, 42);
            this.textbox_p.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "00000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0000000000000000000";
            this.textbox_p.Name = "textbox_p";
            this.textbox_p.Size = new System.Drawing.Size(100, 22);
            this.textbox_p.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(109, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "q =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "p =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.in_decrypt_textbox);
            this.groupBox2.Controls.Add(this.textbox_n);
            this.groupBox2.Controls.Add(this.out_decrypt_textbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textbox_d);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифровать";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(109, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // in_decrypt_textbox
            // 
            this.in_decrypt_textbox.Location = new System.Drawing.Point(431, 71);
            this.in_decrypt_textbox.Name = "in_decrypt_textbox";
            this.in_decrypt_textbox.Size = new System.Drawing.Size(150, 22);
            this.in_decrypt_textbox.TabIndex = 22;
            // 
            // textbox_n
            // 
            this.textbox_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_n.Location = new System.Drawing.Point(198, 50);
            this.textbox_n.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0";
            this.textbox_n.Name = "textbox_n";
            this.textbox_n.Size = new System.Drawing.Size(100, 22);
            this.textbox_n.TabIndex = 19;
            // 
            // out_decrypt_textbox
            // 
            this.out_decrypt_textbox.Location = new System.Drawing.Point(625, 71);
            this.out_decrypt_textbox.Multiline = true;
            this.out_decrypt_textbox.Name = "out_decrypt_textbox";
            this.out_decrypt_textbox.Size = new System.Drawing.Size(150, 112);
            this.out_decrypt_textbox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "OUT";
            // 
            // textbox_d
            // 
            this.textbox_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_d.Location = new System.Drawing.Point(44, 50);
            this.textbox_d.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0000000000000";
            this.textbox_d.Name = "textbox_d";
            this.textbox_d.Size = new System.Drawing.Size(100, 22);
            this.textbox_d.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "n =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "d =";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox textbox_q;
        private System.Windows.Forms.MaskedTextBox textbox_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox out_encrypt_textbox;
        private System.Windows.Forms.TextBox in_encrypt_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in_decrypt_textbox;
        private System.Windows.Forms.MaskedTextBox textbox_n;
        private System.Windows.Forms.TextBox out_decrypt_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textbox_d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}