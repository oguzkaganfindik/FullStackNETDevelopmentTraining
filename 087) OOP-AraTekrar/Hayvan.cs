using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _087__OOP_AraTekrar
{
    internal class Hayvan
    {
        public Hayvan()
        {

        }

        public Hayvan(int id, string ad, string tur, int yas)
        {
            Id = id;
            Ad = ad;
            Tur = tur;
            Yas = yas;
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yas { get; set; }

        public void BilgileriGoster()
        {
            Console.WriteLine("Id --> " + Id);
            Console.WriteLine("Ad --> " + Ad);
            Console.WriteLine("Tur --> " + Tur);
            Console.WriteLine("Yas --> " + Yas);
        }
    }
}
