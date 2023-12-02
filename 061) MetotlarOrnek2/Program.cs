// Parametre olarak bir sayı alıp, bu sayının tek olup olmama durumunu geriye dönen bir metot.

bool TekMi(int x)
{
    if (x % 2 != 0)
        return true;
    // else koymaya gerek yok. Çünkü tek ise zaten kodlar buraya kadar gelemeyecek, üst satırda metottan çıkılacak. Çıkılmadıysa zaten çifttir, o zaman return false çalışacak.
    return false;
}

Console.WriteLine("Tek olup olmadığını kontrol etmek istediğiniz sayıyı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

if (TekMi(sayi))
    Console.WriteLine("Sayı tektir.");
else
    Console.WriteLine("Sayı çifttir.");

// Yukarıdaki gibi bir sayı alıp, bu sayı tek ise, tektir, çift ise, çifttir yazdıran bir metot yazınız.

void KontrolEt(int sayi)
{
    if (sayi % 2 == 0)
        Console.WriteLine("Çifttir.");
    else
        Console.WriteLine("Tektir");
}

KontrolEt(sayi);

// return -> geriye değer döndüren metotta bulunur
// return yok ise metodun dönüş tipi -> void