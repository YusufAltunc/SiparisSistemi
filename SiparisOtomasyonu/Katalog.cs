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
    public partial class Katalog : Form
    {
        public int KatalogID;
        public Katalog()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        
        public void list()
        {
            SqlCommand komut = new SqlCommand("Select urunadi,urunfiyat From Tbl_Urun", bgl.baglanti());
            SqlDataAdapter adap= new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            cmburun.DataSource = dt;
            cmburun.ValueMember = "urunfiyat";
            cmburun.DisplayMember = "urunadi";
            bgl.baglanti().Close();
        }
        
        private void Katalog_Load(object sender, EventArgs e)
        {
            list();


        }
       
        

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            x += 1;
            textBox1.Text = x.ToString();
            button2.Enabled = true;

        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if(x == 1)
            {
                button2.Enabled = false;
                x -= 1;
                textBox1.Text = x.ToString();

            }
            else
            {
                button2.Enabled = true;
                x -= 1;
                textBox1.Text = x.ToString();

            }




        }
        public int fiyat;


        int kutuuruntoplamkg;
        Urun urn = new Urun();
        int mesaj = Urun.KUTUAGIRLIK;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SiparisDetayi sd = new SiparisDetayi();
            sd.VergiStatu = 1;
            sd.Miktar = sd.AgirlikHesapla(Convert.ToInt32(textBox1.Text));
            fiyat = sd.AraToplamHesapla(Convert.ToInt32(cmburun.SelectedValue), Convert.ToInt32(textBox1.Text));
            textBox2.Text = fiyat.ToString();
            kutuuruntoplamkg = urn.UrunMiktarAgirligi(Convert.ToInt32(mesaj), Convert.ToInt32(textBox1.Text));
            label5.Text = "Kargo Ağırlığınız "+kutuuruntoplamkg.ToString()+"KG gelmektedir.";

        }
       
        
        

        

        private void button4_Click(object sender, EventArgs e)
        {
            SiparisVeMusteriBilgi frm = new SiparisVeMusteriBilgi();
            frm.odemeyontm = odemeturu;
            frm.Id = KatalogID;
            frm.urunadi = cmburun.Text;
            frm.urunmiktari = textBox1.Text.ToString();
            frm.KargoAgirlik = kutuuruntoplamkg.ToString();
            frm.Fiyat = fiyat.ToString();
            
            frm.Show();
            this.Hide();

        }
        public string odemeturu;
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nakit")
            {
                odemeturu = comboBox1.Text;
                label7.Text = odemeturu;
            }
            else if(comboBox1.Text =="Kredi Kartı" )
            {
                    odemeturu = comboBox1.Text;
                    label7.Text = odemeturu;
            }
            else if( comboBox1.Text == "Çek")
            {
                odemeturu = comboBox1.Text;
                label7.Text = odemeturu;

            }
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
    }
}
