
// mesela 2 elemanlı bir dizimiz olsun, bunu 5 elemanlı hale getirelim.

int[] dizi1 = new int[2];

foreach (int item in dizi1)
{
    Console.WriteLine(item);
}

Console.WriteLine("----- YENİDEN BOYUTLANDIRILIYOR -----");

Array.Resize(ref dizi1, 5);

foreach (int item in dizi1)
{
    Console.WriteLine(item);
}

Console.WriteLine("----- DİZİYE YENİ ELEMAN EKLEMEK -----");

int[] sayilar = { 5, 4 };


Array.Resize(ref sayilar, sayilar.Length + 1); // Şu anki uzunluğunun 1 fazlası haline getirip sonuna yeni bir alan açıyorum.

// son elemana ekleme yapabilirim.
sayilar[sayilar.Length - 1] = 8;