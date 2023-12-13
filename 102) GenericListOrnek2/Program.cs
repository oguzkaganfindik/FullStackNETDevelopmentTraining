
// Bir Müşteri kayıt sistemi, 3 adet müşteri kayıt etmek istiyoruz. (Bilgiler statik olarak girilecek.)

// Müşteri -> Müşteri numarası - Adı - Aldığı ürün sayısı - Tel no

// 3 adet müşteri nesnesi oluşturup bunları listeye atınız.

// Ardından aşağıdaki raporları ayrı ayrı getiriniz.

// 1 -> Bütün müşterilerimin ad ve telefon numarası bilgileri

// 2 -> Ürün almayan müşterilerimin ad ve telefon numarası bilgileri

// 3 -> En çok ürün alan müşterinin ad bilgisi ve aldığı ürün sayısı

using _102__GenericListOrnek2;

Musteri musteri1 = new Musteri()
{
    MusteriNo = "12",
    Ad = "Ajda Pekkan",
    AldigiUrunSayisi = 59,
    TelNo = "1111111"
};

Musteri musteri2 = new Musteri()
{
    MusteriNo = "77",
    Ad = "Safiye Soyman",
    AldigiUrunSayisi = 0,
    TelNo = "2222222"
};

Musteri musteri3 = new Musteri()
{
    MusteriNo = "1",
    Ad = "Seda Sayan",
    AldigiUrunSayisi = 100,
    TelNo = "333333333"
};

List<Musteri> musteriler = new List<Musteri>();

musteriler.Add(musteri1);
musteriler.Add(musteri2);
musteriler.Add(musteri3);

Console.WriteLine("----- RAPOR 1 ---- Tüm Müşteriler ve Telefon Numaraları");
foreach (var item in musteriler)
{
    Console.WriteLine(item.Ad + " ---> " + item.TelNo);
}

Console.WriteLine("----- RAPOR 2 ---- Ürün almayan müşterilerimin bilgileri");
foreach (var item in musteriler)
{
    if (item.AldigiUrunSayisi == 0)
        Console.WriteLine(item.Ad + " ---> " + item.TelNo);
}

Console.WriteLine("----- RAPOR 3 ----- En çok ürün alan müşterinin bilgileri");

Musteri enCokUrunAlan = musteriler[0];
// ilk müşteriyi en çok ürün alan olarak kabul ettim.

// tek tek en çok ürün alandan daha çok ürün alan var mı diye kontrol ediyorum.

// var ise öne alınıyor.
foreach (var item in musteriler)
{
    if (item.AldigiUrunSayisi > enCokUrunAlan.AldigiUrunSayisi)
        enCokUrunAlan = item;
}

Console.WriteLine("En çok ürün alan ---> " + enCokUrunAlan.Ad);