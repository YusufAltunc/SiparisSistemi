using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SiparisOtomasyonu
{
     class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=Siparis_Otomasyon;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
        
        
        
    }
}
