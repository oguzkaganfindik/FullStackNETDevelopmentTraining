using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092__EncapsulationOrnek1
{
    internal class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        int _kapiSayisi;
        public int KapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                // value -> atanılmak istenilen değer.
                // _kapiSayisi -> atanan değerin tut
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("UYARI!");
                    _kapiSayisi = -1;
                }
            }

        }

    }
}
