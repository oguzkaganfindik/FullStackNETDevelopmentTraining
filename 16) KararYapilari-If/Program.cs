/*
    
    ==  (eşit mi)
    >   (büyük mü)
    <   (küçük mü)
    <=  (küçük eşit mi)
    >=  (büyük eşit mi)
    !=  (eşit değil mi)


*/

// Kullanıcıdan alınan bir sayının 10'a göre durumunu yazdırınız.

using System.Collections.Concurrent;

Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 10)
{
    Console.WriteLine("sayınız 10'dan büyük!");
}
else
{
    Console.WriteLine("sayınız 10'dan küçük veya eşit");
}
Console.WriteLine("uygulama devam ediyor.");

Console.WriteLine("--------------------------------------");
if (sayi > 10)
{
    Console.WriteLine("Sayınız 10'dan büyük.");
}
else if (sayi == 10)
{
    Console.WriteLine("Sayınız 10'a eşit.");
}
else
{
    Console.WriteLine("Sayınız 10'dan küçük.");
}
//istediğimiz kadar else if ekleyebiliriz.
//else if -> Yukarıdaki koşul sağlanmasıysa bir de buna bak.
// else -> Yukarıdaki koşullardan hiçbiri sağlanmadıysa, bunu yap.