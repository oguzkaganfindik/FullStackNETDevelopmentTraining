
// Kullanıcıdan 5 adet sayı alıp bunların en büyüğünü ve en küçüğünü Sort metodu kullanarak yazdırınız.

int[] sayilar = new int[5];

for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine("Sayı giriniz.");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(sayilar);

// DİZİYİ GÖRELİM.
Console.WriteLine("------ SAYILAR ------");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("EN KÜÇÜK -> " + sayilar[0]);
Console.WriteLine("EN BÜYÜK -> " + sayilar[sayilar.Length - 1]);