using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public abstract class Odeme
    {
        public int Tutar { get; set; }
        
        public abstract string OdemeYap();

    }
}
