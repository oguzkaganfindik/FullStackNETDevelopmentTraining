

// Ogrenci -> AdSoyad, Yas, ProjeNotu

// Egitmen -> AdSoyad, Brans, Maas

// 2 class'ı da tanımlayınız. 1 egitmen, 1 ogrenci nesnesi oluşturup, değerlerini atayınız (static)

// atanan bu değerleri tek tek ekrana yazdırınız.

using _077__ClassOrnek1;

Ogrenci ogrenci = new Ogrenci()
{
    AdSoyad = "Şebnem Ferah",
    Yas = 21,
    ProjeNotu = 100
};

Egitmen egitmen = new Egitmen()
{
    AdSoyad = "Teoman Yakupoğlu",
    Brans = "Müzik",
    Maas = 100000
};


Console.WriteLine("Öğrencinin bilgileri: ");
Console.WriteLine("Ad Soyad -> " + ogrenci.AdSoyad);
Console.WriteLine("Yaş -> " + ogrenci.Yas);
Console.WriteLine("Proje Notu -> " + ogrenci.ProjeNotu);

Console.WriteLine("Test ----> " + ogrenci);

Console.WriteLine("-------------------------------------");

Console.WriteLine("Eğitmenin bilgileri: ");
Console.WriteLine("Ad Soyad -> " + egitmen.AdSoyad);
Console.WriteLine("Branş -> " + egitmen.Brans);
Console.WriteLine("Maaş -> " + egitmen.Maas);