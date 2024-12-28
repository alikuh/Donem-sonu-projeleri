using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Ogrenci
    {
        public string AdSoyad { get; set; }
        public string Ders { get; set; }
        public string Egitmen { get; set; }

        public Ogrenci(string adSoyad, string ders, string egitmen) {
            AdSoyad = adSoyad;
            Ders = ders;
            Egitmen = egitmen;
        }
    } 
    public class yetkili_sayfa
    {
        public string e_posta {  get; set; }
        public string sifre { get; set; }
        

        public yetkili_sayfa(string email, string password)
        {
            e_posta = email;
            sifre = password;
            
        }
    }
}
