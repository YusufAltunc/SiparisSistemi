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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public int ktlgıd;

        private void button1_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog();
            katalog.KatalogID = ktlgıd;
            katalog.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciBilgi kln = new KullaniciBilgi();
            kln.iddd = ktlgıd;
            kln.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MüsteriGirisi frrr = new MüsteriGirisi();
            frrr.Show();
            this.Hide();
        }
    }
}
