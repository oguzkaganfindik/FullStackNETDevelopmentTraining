

// Kare, Dikdortgen, Dikucgen AlanHesapla() metodu override edilecek.

// prop -> genislik - yukseklik

// Bir BaseGeometrikSekil Base Class'ı ile yapılabilir.

// Her class'tan birer nesne türetip, alanını hesaplayınız.

using _106__PolymorphismOrnek.Models;

Dikdortgen dikdortgen = new Dikdortgen()
{
    Genislik = 10,
    Yukseklik = 20
};

Kare kare = new Kare()
{
    Genislik = 10,
    Yukseklik = 10
};

DikUcgen dikUcgen = new DikUcgen()
{
    Genislik = 30,
    Yukseklik = 40
};

dikdortgen.AlanHesapla();
kare.AlanHesapla();
dikUcgen.AlanHesapla();