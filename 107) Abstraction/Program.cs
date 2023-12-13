
// Abstraction

// Abstract -> Soyut -> Bu klasörde miras veren, nesne oluşturulmayan classlar
// Concrete -> Somut  -> Nesne oluşturulanlar

using _107__Abstraction.Concrete;

// BaseMuzikAleti bma = new BaseMuzikAleti(); abstract bir class olduğu için newlenemez. Çünkü tek görevi miras vermek.

Bateri bateri = new Bateri()
{
    Marka = "Yamaha",
    Aciklama = "Ritim sevenler için müq"
};

Flut flut = new Flut()
{
    Marka = "Yamaha",
    Aciklama = "Daha dün annemizin çalmak için en iddialı müzik aleti"
};

Gitar gitar = new Gitar()
{
    Marka = "Yamaha",
    Aciklama = "Akdeniz Akşamları remix için"
};

bateri.SesVer();
flut.SesVer();
gitar.SesVer();
// Kare, Dikdortgen, Dikucgen AlanHesapla() metodu override edilecek.

// prop -> genislik - yukseklik

// Bir BaseGeometrikSekil Base Class'ı ile yapılabilir.