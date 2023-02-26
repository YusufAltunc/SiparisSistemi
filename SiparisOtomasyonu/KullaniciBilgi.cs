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
    public partial class KullaniciBilgi : Form
    {
        public int iddd;
        public KullaniciBilgi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void KullaniciBilgi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tbl_Musteri where ID="+iddd,bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
