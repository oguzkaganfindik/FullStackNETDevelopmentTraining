using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090__StaticOrnek.Models
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double VizeNotu { get; set; }
        public double FinalNotu { get; set; }
        public static string Brans { get; set; }

    }
}
