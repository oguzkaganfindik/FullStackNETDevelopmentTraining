using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081__OopGirisTekrar
{
    public class Kitap
    {
        public Kitap()
        {
            KayitTarihi = DateTime.Now;
        }

        public Kitap(string ad, string yazarAd, int sayfaSayisi, string yayinEvi)
        {
            KayitTarihi = DateTime.Now;

            Ad = ad;
            YazarAd = yazarAd;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayinEvi;
        }
        public string Ad { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string YayinEvi { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
