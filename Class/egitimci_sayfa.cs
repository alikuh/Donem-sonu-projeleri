using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
   
    public class egitimci_sayfa 
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telNo { get; set; }
        public int yas { get; set; }
        public string tcNo { get; set; }

        
        public bool kontrolAdSoyad()
        {
            return !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad);
        }

        public bool kontrolTelNo()
        {
            return !string.IsNullOrWhiteSpace(telNo) && telNo.All(char.IsDigit) && telNo.Length == 10;
        }

        public bool kontrolYas()
        {
            return yas <= 80;
        }

        public bool kontrolTcNo()
        {
            return tcNo.Length == 11 && tcNo.All(char.IsDigit) && tcNo[0] != '0';
        }
    }
   
}
