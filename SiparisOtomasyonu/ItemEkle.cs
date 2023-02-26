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
    public partial class ItemEkle : Form
    {
        public ItemEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi sql = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            int kgfiyati= urun.UrunMiktarDegeri(Convert.ToInt32(txtToplamKG.Text), Convert.ToInt32(txtMaliyet.Text));

            SqlCommand cmd = new SqlCommand("insert into Tbl_Urun(urunadi,urunfiyat,uruntoplamkg)values(@p1,@p2,@p3)",sql.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",kgfiyati);
            cmd.Parameters.AddWithValue("@p3", txtToplamKG.Text);

            cmd.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show(txtToplamKG.Text + "kg " + txtAd.Text + " Eklendi.", "Bilgi");
           // int toplamagırlık=urun.UrunMiktarAgirligi(Convert.ToInt32(txtToplamKG.Text),)
          // urun.KargoAgirligi =urun.UrunMiktarAgirligi(Convert.ToInt32(txtToplamKG.Text),Convert.ToInt32());


        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightYellow;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminKullaniciBilgi ss = new AdminKullaniciBilgi();
            ss.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUrunBilgi nn = new AdminUrunBilgi();
            nn.Show();
        }
    }
}
