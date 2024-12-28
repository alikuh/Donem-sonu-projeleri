using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ogrenci 
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telNo { get; set; }
        public int yas { get; set; }
        public string tcNo { get; set; }

        public bool KontrolAdSoyad()
        {
            return !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad);
        }

        public bool KontrolTelNo()
        {
            return !string.IsNullOrWhiteSpace(telNo) && telNo.All(char.IsDigit) && telNo.Length == 10;
        }

        public bool KontrolYas()
        {
            return yas >= 10;
        }

        public bool KontrolTcNo()
        {
            return tcNo.Length == 11 && tcNo.All(char.IsDigit) && tcNo[0] != '0';
        }

    }
}
