// Bir öğrenci -> Ad, Soyad, Öğrenci Numarası
// Bir öğretmen -> Ad, Soyad, Maaş

// Kisi diye bir base class oluşturalım. (BaseKisi)

// Ogrenci ve Ogretmen classları base classtan türesin ( miras alsın)

// Bir nesneye ait Ad ve Soyad bilgisini ekrana yazdıran bir metodum olsun. ( AdSoyadYazdir() )

// Bir nesnenin bütün özelliklerini ekrana yazdıran bir metodum olsun. ( Öğretmen için -> BilgileriYazdir() // Ogrenci için -> BilgileriYazdir() )


using _097__InheritanceOrnek1.Models;

Ogrenci ogrenci1 = new Ogrenci()
{
    Ad = "Demet",
    Soyad = "Evgar",
    OgrenciNo = "10"
};

ogrenci1.AdSoyadYazdir();
Console.WriteLine("-------------------");
ogrenci1.BilgileriYazdir();

Console.WriteLine("------------------------------");

Ogretmen ogretmen1 = new Ogretmen()
{
    Ad = "Hadise",
    Soyad = "Açıkgöz",
    Maas = 21313213123.23M
};

ogretmen1.BilgileriYazdir();