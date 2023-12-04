// Parametre olarak 2 sayı alıp bunların yerlerini değiştiren metot.
// Değişim kalıcı olacak.

void Degistir(ref int s1, ref int s2)
{
    int gecici;
    gecici = s1;
    s1 = s2;
    s2 = gecici;
}

Console.WriteLine("Birinci sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Degistir(ref sayi1, ref sayi2);

Console.WriteLine("Sayı 1 ----> " + sayi1);
Console.WriteLine("Sayı 2 ----> " + sayi2);