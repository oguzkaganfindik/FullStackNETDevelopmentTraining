// Ekrana aşağıdaki çıktıyı veren kodu yazınız.

/*

1 - Elma
2 - Elma
3 - Elma
4 - Elma

*/

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine(i + "- Elma");
}
Console.WriteLine("------------------------------------------");

// Ekrana kullanıcının istediği sayıda "Merhaba" yazınız.

Console.WriteLine("Kaç kere merhaba yazdıralım?");
int tekrarSayisi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= tekrarSayisi; i++)
{
    Console.WriteLine("Merhaba");
}
Console.WriteLine("------------------------------------------");
// 1'den 10'a kadar olan sayıların toplamını yazınız.

int toplam = 0;
for (int i = 1; i <= 10; i++)
{
    toplam = toplam + i;
    Console.WriteLine("Toplam -> " + toplam);
}
Console.WriteLine("------------------------------------------");
// 20 ile 75 arasındaki tek ve çift sayıların toplamını ayrı ayrı yazdırınız. (Tek bir FOR ile)
int teklerToplami = 0;
int ciftlerToplami = 0;

for (int i = 20; i <= 75; i++)
{
    if (i % 2 == 0)
        ciftlerToplami = ciftlerToplami + i;
    else
        teklerToplami = teklerToplami + i;
}
Console.WriteLine("Teklerin Toplamı ---> " + teklerToplami);
Console.WriteLine("Çiftlerin Toplamı ---> " + ciftlerToplami);
Console.WriteLine("------------------------------------------");

// Kullanıcıdan alınan sayının faktöriyelini hesaplayan uygulama
Console.WriteLine("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz?");
int sayi = Convert.ToInt32(Console.ReadLine());
int faktoriyel = 1;
for (int i = 1; i <= sayi; i++)
{
    faktoriyel = faktoriyel * i;
}
    Console.WriteLine(sayi + " sayisinin faktöriyeli = " + faktoriyel);