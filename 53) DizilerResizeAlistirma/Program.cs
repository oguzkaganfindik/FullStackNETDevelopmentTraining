
// Kullanıcının istediği adet rastgele sayıdan oluşan bir dizi tanımlayınız.
Console.WriteLine("Kaç elemanlı bir dizi istersiniz?");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[elemanSayisi];

Random rnd = new Random();

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 25);
}

// ardından bu diziye kullanıcının istediği yeni bir sayıyı ekleyiniz.

Console.WriteLine("Yeni eklemek istediğiniz sayı nedir?");
int eklenecek = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar, sayilar.Length + 1);

sayilar[sayilar.Length - 1] = eklenecek;

// _ _ _ _

// dizinin elemanlarını büyükten küçüğe sıralayınız.

Array.Sort(sayilar); // küçükten büyüğe sırala
Array.Reverse(sayilar); // ters çevir.

Console.WriteLine(" ..... SAYILAR .....");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}


// En küçük değerdeki elemanı yazdırınız.
Console.WriteLine("En küçük eleman -> " + sayilar[sayilar.Length - 1]);