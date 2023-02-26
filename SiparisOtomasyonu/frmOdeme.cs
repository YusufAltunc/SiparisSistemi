using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class frmOdeme : Form
    {
        public string odemeyontemii;
        public string tutarr;
        Nakit nk = new Nakit();
        Cek ck = new Cek();
        KrediKarti kk = new KrediKarti();
        
        public frmOdeme()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nk.OdemeYap());
            Application.Exit();
        }
        


        private void frmOdeme_Load(object sender, EventArgs e)
        {
            if(odemeyontemii == "Kredi Kartı")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                kk.AlısverisUcret = Convert.ToInt32(tutarr);
                label10.Text = kk.AlısverisUcret.ToString();

            }
            else if(odemeyontemii == "Çek")
            {
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                ck.CekDegeri= Convert.ToInt32(tutarr);
                label8.Text = ck.CekDegeri.ToString();
            }
            else if(odemeyontemii=="Nakit")
            {
                groupBox2.Visible=false;
                groupBox3.Visible=false;
                nk.OdenenNakit = Convert.ToInt32(tutarr);

                label5.Text = nk.OdenenNakit.ToString();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ck.CeksahibiAdi+"\n"+ck.BankaAdi+"\n"+ck.OdemeYap());
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kredi Kart No: "+kk.KrediKartiNo+"\n"+"SKK: "+kk.SonKullanmaTarihi+"\n"+"CCV: "+kk.CcvNumarasi+"\n"+"Kredi Kartı tipi: "+kk.KrediKartiTipi+"\n"+kk.OdemeYap());
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ck.CeksahibiAdi=textBox3.Text.ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ck.BankaAdi=comboBox1.Text.ToString();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            kk.KrediKartiNo=maskedTextBox1.Text;
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            kk.SonKullanmaTarihi=maskedTextBox2.Text;
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            kk.CcvNumarasi = Convert.ToInt32(maskedTextBox3.Text);
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            kk.KrediKartiTipi = "Visa";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            kk.KrediKartiTipi = "Mastercard";
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
