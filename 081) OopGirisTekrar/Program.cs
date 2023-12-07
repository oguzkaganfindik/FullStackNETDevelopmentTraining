
// Ad, YazarAd, SayfaSayisi, YayinEvi, KayitTarihi bilgileri ile kitaplar kaydetmek istiyoruz.

// Örnek bir kitap olan Ayşe Kulin'in 390 sayfalık, Everest yayınevinden çıkan Adı Aylin kitabını oluşturunuz.

// 2 Adet constructor alternatifi olsun. Bir tanesi default constructor tarzında parametre almadan çalışan, diğeri ad, yazarAdi, SayfaSayisi, yayiEvi bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir constructor.

// KayitTarihi nesne oluşturulunca otomatik atansın.

// Ardından örnek üzerinden Class, Property, New, Constructor kavramlarını tanımlayınız.

using _081__OopGirisTekrar;

Kitap kitap = new Kitap("Adı Aylin", "Ayşe Kulin", 390, "Everest");

Console.WriteLine("EKLENEN KİTABIN BİLGİLERİ");
Console.WriteLine("Ad -> " + kitap.Ad);
Console.WriteLine("Yazar -> " + kitap.YazarAd);
Console.WriteLine("....");

// Class -> Bir nesne oluşturma şablonu
// Property -> Oluşturan nesnenin özellikleri.
// New -> Nesneyi oluşturmak.
// Constructor -> Nesne oluşturulunca otomatik tetiklenen metot.