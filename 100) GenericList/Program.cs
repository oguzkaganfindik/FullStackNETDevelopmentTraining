
// GenericList

// Generic -> verilen değişken tipine göre şekil alan

// List -> Bir kolleksiyon yapı -> Yani birden fazla veriyi birt arada tutmaya yarar. ( AYNI TİPTE VERİLER )

List<int> sayilar = new List<int>(); // Bir dizinin tanımlanması

sayilar.Add(3);
sayilar.Add(5);
sayilar.Add(-1);
sayilar.Add(3);
sayilar.Add(3);

// Bir listedeki eleman sayısı
Console.WriteLine("Bu listede --> " + sayilar.Count + " tane eleman var.");

// Listedeki elemanları for ile yazdırma

for (int i = 0; i < sayilar.Count; i++)
{
    Console.WriteLine(sayilar[i]);
}

Console.WriteLine("********************");
// Listedeki elemanları foreach ile yazdırma

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

// değer ile silme
sayilar.Remove(3); // listedeki ilk '3' değerini sil.

// index ile silme
sayilar.RemoveAt(1); // 1. indexteki elemanı sil.

Console.WriteLine("********************");
// listenin son hali
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}