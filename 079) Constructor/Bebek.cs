using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _079__Constructor
{
    public class Bebek
    {
        // Constructor -> Class ile aynı isimde, herhangi bir tipi olmayan metot.
        // Bir class new'lendiği anda, constructor otomatik ve zorunlu olarak tetiklenir.
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Bebek Sesi");

            // Bir bebek oluşturulduğu an tarih/zaman bilgisi direkt propert'e atansın ve "Bebek Sesi" yazdırılsın.
        }
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public double Kilo { get; set; }
    }
}
