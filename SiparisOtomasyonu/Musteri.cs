using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public string Adres { get; set; }
        public Katalog katalog { get; set; }

        public Musteri()
        {
            Katalog katalog = new Katalog();
            
        }

    }
}
