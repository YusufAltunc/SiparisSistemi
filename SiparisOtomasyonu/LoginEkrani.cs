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
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }
        

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            MüsteriGirisi frm = new MüsteriGirisi();
            frm.Show();
            this.Hide();
        }

        

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightYellow;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminGirisi frm = new AdminGirisi();
            frm.Show();
            this.Hide();
        }

        
    }
}
