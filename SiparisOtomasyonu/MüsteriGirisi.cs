using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiparisOtomasyonu
{
    public partial class MüsteriGirisi : Form
    {
        public int Id;
        public MüsteriGirisi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri Where kullanıcıadı=@p1 and sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Id = Convert.ToInt32(dr[0]);
                AnaEkran frm = new AnaEkran();
                frm.ktlgıd = Id;
                /*Katalog fr = new Katalog();
                fr.KatalogID=Id;*/
                // fr.mesaj = "Hosgeldiniz " + dr[1] + " " + dr[2] + " almak istediğiniz şeyleri seçiniz.";
                
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre");
            }
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightYellow;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtEkranı fm = new KayıtEkranı();
            fm.Show();
        }
    }
}
