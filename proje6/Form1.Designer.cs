namespace proje6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.grphesapmakinesi = new System.Windows.Forms.GroupBox();
            this.btntopla = new System.Windows.Forms.Button();
            this.btnİslem = new System.Windows.Forms.Button();
            this.btnvirgul = new System.Windows.Forms.Button();
            this.btnCıkart = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBöl = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grphesapmakinesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(29, 145);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(29, 61);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(202, 27);
            this.txtSayi.TabIndex = 1;
            // 
            // grphesapmakinesi
            // 
            this.grphesapmakinesi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grphesapmakinesi.Controls.Add(this.btnSil);
            this.grphesapmakinesi.Controls.Add(this.btnSifirla);
            this.grphesapmakinesi.Controls.Add(this.btntopla);
            this.grphesapmakinesi.Controls.Add(this.btnİslem);
            this.grphesapmakinesi.Controls.Add(this.btnvirgul);
            this.grphesapmakinesi.Controls.Add(this.btnCıkart);
            this.grphesapmakinesi.Controls.Add(this.btnCarp);
            this.grphesapmakinesi.Controls.Add(this.btnBöl);
            this.grphesapmakinesi.Controls.Add(this.btn0);
            this.grphesapmakinesi.Controls.Add(this.btn9);
            this.grphesapmakinesi.Controls.Add(this.btn8);
            this.grphesapmakinesi.Controls.Add(this.btn7);
            this.grphesapmakinesi.Controls.Add(this.btn6);
            this.grphesapmakinesi.Controls.Add(this.btn5);
            this.grphesapmakinesi.Controls.Add(this.btn4);
            this.grphesapmakinesi.Controls.Add(this.btn3);
            this.grphesapmakinesi.Controls.Add(this.btn2);
            this.grphesapmakinesi.Controls.Add(this.txtSayi);
            this.grphesapmakinesi.Controls.Add(this.btn1);
            this.grphesapmakinesi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grphesapmakinesi.Location = new System.Drawing.Point(120, 65);
            this.grphesapmakinesi.Name = "grphesapmakinesi";
            this.grphesapmakinesi.Size = new System.Drawing.Size(262, 371);
            this.grphesapmakinesi.TabIndex = 2;
            this.grphesapmakinesi.TabStop = false;
            this.grphesapmakinesi.Text = "Hesap Makinesi";
            // 
            // btntopla
            // 
            this.btntopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntopla.Location = new System.Drawing.Point(185, 298);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(46, 45);
            this.btntopla.TabIndex = 16;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // btnİslem
            // 
            this.btnİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslem.Location = new System.Drawing.Point(133, 298);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(46, 45);
            this.btnİslem.TabIndex = 15;
            this.btnİslem.Text = "=";
            this.btnİslem.UseVisualStyleBackColor = true;
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // btnvirgul
            // 
            this.btnvirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvirgul.Location = new System.Drawing.Point(29, 298);
            this.btnvirgul.Name = "btnvirgul";
            this.btnvirgul.Size = new System.Drawing.Size(46, 45);
            this.btnvirgul.TabIndex = 14;
            this.btnvirgul.Text = ",";
            this.btnvirgul.UseVisualStyleBackColor = true;
            this.btnvirgul.Click += new System.EventHandler(this.btnvirgul_Click);
            // 
            // btnCıkart
            // 
            this.btnCıkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkart.Location = new System.Drawing.Point(185, 247);
            this.btnCıkart.Name = "btnCıkart";
            this.btnCıkart.Size = new System.Drawing.Size(46, 45);
            this.btnCıkart.TabIndex = 13;
            this.btnCıkart.Text = "-";
            this.btnCıkart.UseVisualStyleBackColor = true;
            this.btnCıkart.Click += new System.EventHandler(this.btnCıkart_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(185, 196);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(46, 45);
            this.btnCarp.TabIndex = 12;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBöl
            // 
            this.btnBöl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBöl.Location = new System.Drawing.Point(185, 145);
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.Size = new System.Drawing.Size(46, 45);
            this.btnBöl.TabIndex = 11;
            this.btnBöl.Text = "/";
            this.btnBöl.UseVisualStyleBackColor = true;
            this.btnBöl.Click += new System.EventHandler(this.btnBöl_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(81, 298);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 45);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(133, 247);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(81, 247);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 45);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(29, 247);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 45);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(133, 196);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(81, 196);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 45);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(29, 196);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 45);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(133, 145);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(81, 145);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(29, 94);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(46, 45);
            this.btnSifirla.TabIndex = 17;
            this.btnSifirla.Text = "C";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(81, 94);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(46, 45);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "<";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 465);
            this.Controls.Add(this.grphesapmakinesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grphesapmakinesi.ResumeLayout(false);
            this.grphesapmakinesi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.GroupBox grphesapmakinesi;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btnİslem;
        private System.Windows.Forms.Button btnvirgul;
        private System.Windows.Forms.Button btnCıkart;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBöl;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnSil;
    }
}

