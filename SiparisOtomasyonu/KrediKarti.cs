using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class KrediKarti : Odeme
    {
        public string KrediKartiNo { get; set; }
        public string KrediKartiTipi { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public int CcvNumarasi { get; set; }
        public int AlısverisUcret { get; set; }

        public string kredikartimesaj;

        public KrediKarti()
        {
            AlısverisUcret = Tutar;
        }

        public override string OdemeYap()
        {
            kredikartimesaj = AlısverisUcret + " TL Kredi kartınızdan ödeme talep edilmiştir.";
            return kredikartimesaj;
        }
    }
}
