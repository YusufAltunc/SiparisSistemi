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
    public partial class SiparisVeMusteriBilgi : Form
    {
        public string odemeyontm;
        public int Id;
        public string Fiyat;
        public string KargoAgirlik;
        public string urunmiktari;
        public string urunadi;
        public SiparisVeMusteriBilgi()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();
        SqlBaglantisi bgl = new SqlBaglantisi();
        Urun urun = new Urun();
        

        private void SiparisVeMusteriBilgi_Load(object sender, EventArgs e)
        {
            


            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri Where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Id);
            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                musteri.Ad= dr[1].ToString(); 
                musteri.Soyad = dr[2].ToString();
                musteri.TCNo = dr[4].ToString();
                musteri.Adres = dr[3].ToString();

            }        
            bgl.baglanti().Close();
            lblad.Text = musteri.Ad;
            lblsoyad.Text = musteri.Soyad;
            maskedTextBox1.Text = musteri.TCNo;
            textBox1.Text = musteri.Adres;
            Siparis sp = new Siparis();
            sp.SiparisAdı = urunadi;
            lblurun.Text = sp.SiparisAdı;
            sp.SiparisTarihi =DateTime.Now;
            lblsiparistarih.Text =sp.SiparisTarihi.ToString();
            string agirlik = KargoAgirlik;
            lblagirlik.Text = sp.ToplamAgirlik(agirlik);
            string hesap = Fiyat;
            int mk =Convert.ToInt32 (sp.ToplamHesap(hesap))+sp.VergiHesapla(hesap);
            lblfiyat.Text = mk.ToString();
            lblurunmiktar.Text = urunmiktari;            
            lblodemeyontemi.Text = odemeyontm;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            frmOdeme frmOdeme = new frmOdeme();
            frmOdeme.tutarr = Fiyat;
            frmOdeme.odemeyontemii = odemeyontm;
            frmOdeme.Show();
            this.Hide();
            
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
            pictureBox1.BackColor= Color.Transparent;
        }

        private void lblagirlik_Click(object sender, EventArgs e)
        {

        }
    }
}
