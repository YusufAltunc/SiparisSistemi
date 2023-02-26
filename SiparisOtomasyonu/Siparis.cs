using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu

{
    public class Siparis
    {        
        public const decimal VERGIORANI = 0;
        public DateTime SiparisTarihi { get; set; }
        public string SiparisAdı { get; set; }
        public decimal VergiFiyati { get; set; }

        public int VergiHesapla(string fiyattt)
        {
            
            string vergi = VERGIORANI.ToString();
            int fiyat = Convert.ToInt32(vergi)*Convert.ToInt32(fiyattt);
            return fiyat;                     
        }
        public string ToplamHesap(string toplamhesap)
        {
            return toplamhesap;          
        }
        public string ToplamAgirlik(string agirlik)
        {
            return agirlik;
        }
    }
}
