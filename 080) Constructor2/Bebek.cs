﻿namespace _080__Constructor2
{
    public class Bebek
    {
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Bebek Sesi");
        }

        public Bebek(string ad, string soyad)
        {
            DogumTarihi = DateTime.Now;
            Ad = ad;
            Soyad = soyad;
            Console.WriteLine("bebek Sesi 2");
        }

        public Bebek(string ad, string soyad, bool cinsiyet)
        {
            DogumTarihi = DateTime.Now;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;

            string kizMiErkekMi = cinsiyet ? "Erkek" : "Kız";

            //string kizMiErkekMi = "Erkek";
            //string kizMiErkekMi = "Kız";

            Console.WriteLine(ad + " isimli " + soyad + " soyisimli bir " + kizMiErkekMi + " bebek dünyaya geldiiii.");
        }

        // Bebek class'ında bool Cinsiyet propertysi ekleyiniz. 3. alternatif bir constructor yapınız. ad, soyad, cinsiyet bilgileri alarak bebeği oluştursun.

        // 3. alternatifte çalıştırılınca ->> .... isimli ..... soyisimli Erkek/Kız bebek dünyaya geldi.  Yazdırılsın.

        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
    }
}

       // Parametresiz constructor default olarak her class'ta bulunur. Siz eğer kendi parametreli constructorlarınızı yazarsanız parametresiz default'u iptal etmiş olursunuz. Alternatif olarak onu da sunmak istiyorsanız, yeniden yazmalısınız.
