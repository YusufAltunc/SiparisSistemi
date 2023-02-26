using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Nakit : Odeme
    {
        public int OdenenNakit { get; set; }

        public string mesaj;
        public override string OdemeYap()
        {
            mesaj = OdenenNakit + " TL Nakit ile ödemeniz gerçekleşmiştir.";
            return mesaj;
        }
        public Nakit()
        {
            OdenenNakit = Tutar;
        }
       
    }
}
