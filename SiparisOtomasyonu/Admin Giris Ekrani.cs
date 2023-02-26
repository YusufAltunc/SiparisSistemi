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
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

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

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("Select * From Tbl_Admin where kullaniciadi=@p1 and sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtadmnkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtadmnsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ItemEkle fr = new ItemEkle();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
