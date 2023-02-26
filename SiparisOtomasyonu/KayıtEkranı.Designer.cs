namespace SiparisOtomasyonu
{
    partial class KayıtEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(217, 88);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(187, 36);
            this.txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(217, 156);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(187, 36);
            this.txtsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(546, 159);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(187, 225);
            this.txtadres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres:";
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Location = new System.Drawing.Point(147, 222);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(44, 28);
            this.txttc.TabIndex = 6;
            this.txttc.Text = "TC:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(217, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 36);
            this.textBox5.TabIndex = 9;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.AutoSize = true;
            this.txtkullaniciadi.Location = new System.Drawing.Point(58, 286);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(133, 28);
            this.txtkullaniciadi.TabIndex = 8;
            this.txtkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(217, 348);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 36);
            this.textBox6.TabIndex = 11;
            // 
            // txtsifre
            // 
            this.txtsifre.AutoSize = true;
            this.txtsifre.Location = new System.Drawing.Point(129, 351);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(62, 28);
            this.txtsifre.TabIndex = 10;
            this.txtsifre.Text = "Şifre:";
            // 
            // btnkayit
            // 
            this.btnkayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayit.Font = new System.Drawing.Font("Corbel Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayit.Location = new System.Drawing.Point(217, 413);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(187, 56);
            this.btnkayit.TabIndex = 12;
            this.btnkayit.Text = "Kayıt Yap";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(217, 222);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(187, 36);
            this.msktc.TabIndex = 13;
            this.msktc.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiparisOtomasyonu.Properties.Resources.icons8_delete_30px;
            this.pictureBox1.Location = new System.Drawing.Point(691, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(298, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kayıt Ekranı";
            // 
            // KayıtEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "KayıtEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtkullaniciadi;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label txtsifre;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}