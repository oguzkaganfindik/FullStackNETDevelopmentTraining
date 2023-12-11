// Bir öğrenci classım var, bundan öğrenci nesneleri üretilecek.

// Ad - Soyad - VizeNotu - FinalNotu - Brans

// Bu uygulama yalnızca Brans'ı müzik olan kişiler için kullanılacak

// O nedenle bir öğrenci branşı -> Müzik denilebilir.

// Vize ve Final için katsayılar 0.4-0.6 - Bu sabit değerleri KatSayilar class'ı içerisinde tutalım.

// 2 tane metot var toplam, biri OrtalamaHesapla(), diğeri DurumBildir()
//Metotlar static class içerisinde

// Bir öğrenci nesnesi üzerinden uygulama yapalım.
//--------------------------------------------------


using _090__StaticOrnek.Models;

Ogrenci.Brans = "Müzik";

Ogrenci ogrenci1 = new Ogrenci()
{
    Ad = "Ajda",
    Soyad = "Pekkan",
    VizeNotu = 80,
    FinalNotu = 100
};

double ort = Metotlar.OrtalamaHesapla(ogrenci1.VizeNotu, ogrenci1.FinalNotu);

Metotlar.DurumBildir(ort);

Console.WriteLine("---------------------------------------");
// Konsol ekranında bir öğrenci bilgileri alarak bu uygulamayı test ediniz. Arından debuglayınız.

Ogrenci ogrenci2 = new Ogrenci();

Console.WriteLine("Öğrencinin adını giriniz.");
ogrenci2.Ad = Console.ReadLine();

Console.WriteLine("Öğrencinin soyadını giriniz.");
ogrenci2.Soyad = Console.ReadLine();

Console.WriteLine("Vize notunuz?");
ogrenci2.VizeNotu = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Final notunuz?");
ogrenci2.FinalNotu = Convert.ToDouble(Console.ReadLine());

double sonuc = Metotlar.OrtalamaHesapla(ogrenci2.VizeNotu, ogrenci2.FinalNotu);

Console.WriteLine("ORTALAMANIZ ---> " + sonuc);

Metotlar.DurumBildir(sonuc);