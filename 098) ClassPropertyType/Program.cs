
// Class Property Type

// Sinif -> Isim, Ders, EgitmenAdi, EgitmenSoyadi, EgitmenUzmanligi, OgrenciSayisi

// Egitmen -> Ad, Soyad, Uzmanligi

using _098__ClassPropertyType.Models;

Egitmen egitmen = new Egitmen()
{
    Ad = "Ajda",
    Soyad = "Pekkan",
    Uzmanlik = "Astroloji"
};

Sinif sinif = new Sinif()
{
    Isim = "YZL8748",
    Ders = "Astroloji Eğitimi",
    Egitmen = egitmen,
    OgrenciSayisi = 20
};


Console.WriteLine("Bu sınıfın eğitmeni -> " + sinif.Egitmen.Ad + " " + sinif.Egitmen.Soyad);