namespace SiparisOtomasyonu
{
    partial class AdminGirisi
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtadmnkullaniciadi = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadmnsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin Giriş Ekranı";
            // 
            // txtadmnkullaniciadi
            // 
            this.txtadmnkullaniciadi.Location = new System.Drawing.Point(185, 124);
            this.txtadmnkullaniciadi.Name = "txtadmnkullaniciadi";
            this.txtadmnkullaniciadi.Size = new System.Drawing.Size(182, 28);
            this.txtadmnkullaniciadi.TabIndex = 8;
            // 
            // btngiris
            // 
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(185, 273);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(182, 68);
            this.btngiris.TabIndex = 12;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // txtadmnsifre
            // 
            this.txtadmnsifre.Location = new System.Drawing.Point(185, 202);
            this.txtadmnsifre.Name = "txtadmnsifre";
            this.txtadmnsifre.Size = new System.Drawing.Size(182, 28);
            this.txtadmnsifre.TabIndex = 10;
            this.txtadmnsifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SiparisOtomasyonu.Properties.Resources.icons8_delete_30px;
            this.pictureBox1.Location = new System.Drawing.Point(396, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // AdminGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtadmnkullaniciadi);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadmnsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadmnkullaniciadi;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadmnsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}