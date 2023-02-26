using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Cek : Odeme
    {
        public string CeksahibiAdi { get; set; }
        public string BankaAdi { get; set; }
        public int CekDegeri { get; set; }

        public string cekmesaj;

        public Cek()
        {
            CekDegeri = Tutar;
        }
        public override string OdemeYap()
        {
            cekmesaj = CekDegeri + " TL Çekle ödeme talebiniz alınmıştır.";
            return cekmesaj;

        }
    }
}
