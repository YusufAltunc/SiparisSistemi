using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Urun
    {
        public const int KUTUAGIRLIK = 2;
        public int KargoAgirligi { get; set; }
        public string Aciklama { get; set; }
        public int kgfiyat { get; set; }
       
        public int UrunMiktarDegeri(int toplamkg,int toplamfiyat )
        {
         
            return toplamfiyat / toplamkg;
        }
        public int UrunMiktarAgirligi(int kutuagırlık,int urunkg)
        {
            return kutuagırlık + urunkg;
            
        }

    }
}
