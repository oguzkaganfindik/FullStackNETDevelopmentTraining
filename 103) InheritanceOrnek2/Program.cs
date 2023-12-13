// InheritanceOrnek2

// BaseClass -> BaseCanli 

// Insan -> Ad, Soyad, El Sayısı , Ayak Sayısı
// Köpek -> Ad, Pati Sayısı, Kuduz Mu

// Insan ve Kopek derived Class'lar

// Konus() diye metot var hem insanda hem hayvanda adını söylüyor.

// BilgiVer() metodu ile El sayısı , ayak/pati sayısı , kuduz olma durumu bildirilsin. - 2si için de

// Havla() metodu ile köpek havlatılsın

// Ardından 2 köpek ve 2 insan nesnesi oluşturunuz

// Bu nesneler köpekler ve insanlar listelerine atayınız.

// Bütün köpeklerin ve insanların isimlerini yazdırınız.

using _103__InheritanceOrnek2.NewFolder;

Insan insan1 = new Insan()
{
    Ad = "Banu",
    Soyad = "Alkan",
    ElSayisi = 2,
    AyakSayisi = 2
};
Insan insan2 = new Insan()
{
    Ad = "Murat",
    Soyad = "Övünç",
    ElSayisi = 2,
    AyakSayisi = 2
};
Kopek kopek1 = new Kopek()
{
    Ad = "Taci",
    PatiSayisi = 4,
    KuduzMu = false
};
Kopek kopek2 = new Kopek() { Ad = "Kuci", PatiSayisi = 3, KuduzMu = true };

insan1.BilgiVer();
kopek2.BilgiVer();

List<Insan> insanlar = new List<Insan>();
insanlar.Add(insan1);
insanlar.Add(insan2);

List<Kopek> kopekler = new List<Kopek>();
kopekler.Add(kopek1);
kopekler.Add(kopek2);

Console.WriteLine("INSANLARIN İSİMLERİ");
foreach (var insan in insanlar)
{
    Console.WriteLine(insan.Ad + " " + insan.Soyad);
}

Console.WriteLine("KÖPEKLERİN İSİMLERİ");
foreach (var k in kopekler)
{
    Console.WriteLine(k.Ad);
}

Console.WriteLine("------------------------------------");
// Bütün İnsanlar için metot tetikleyelim.

foreach (var item in insanlar)
{
    item.BilgiVer();
}
