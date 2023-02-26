    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class SiparisDetayi 
    {
        public int Miktar { get; set; }
        public int VergiStatu { get; set; }
        public int fiyat { get; set; }
        public Siparis Siparis { get; set; }
        public SiparisDetayi()
        {
            Siparis Siparis = new Siparis(); //Siparisle composition iliskide olmali(yapıldı)
            
        }
        public int AraToplamHesapla(int miktar,int kgfiyat)
        {
            fiyat = miktar * kgfiyat;
            return fiyat;
        }
        public int AgirlikHesapla(int x)
        {
            this.Miktar = x;
            return Miktar;
        }

    }
}
