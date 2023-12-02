// Ekrana 5 kere "Kırmızı güller aşkın temsilcisi" yazan for döngüsü

string kirmiziGuller = "Kırmızı güller aşkın temsilcisi";
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(kirmiziGuller);
}

Console.WriteLine("---------------------------------------");

// Ekrana kullanıcının istediği sayıda "Merhaba" yazan bir for döngüsü.

Console.WriteLine("Kaç defa 'Merhaba' yazılsın? ");
int tekrarSayisi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < tekrarSayisi; i++)
{
    Console.WriteLine("Merhaba");
}

Console.WriteLine("---------------------------------------");

// Ekrana 1'den 10'a kadar olan sayıları yazan ve bu sayılardan tek olanların ve çift olanların toplamlarını ayrı ayrı yazdıran bir for döngüsü.
int teklerToplam = 0;
int ciftlerToplam = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
    if (i % 2 == 0)
        ciftlerToplam += i;
    else
        teklerToplam += i;
}
Console.WriteLine("Tekler Toplamı ----> " + teklerToplam);
Console.WriteLine("Çiftler Toplamı ----> " + ciftlerToplam);

Console.WriteLine("---------------------------------------");
// Ekrana 15'den 20'e kadar olan sayıların toplamınu yazan bir for döngüsü.

int toplam = 0;

for (int i = 15; i <= 20; i++)
{
    toplam = toplam + i;
}
Console.WriteLine("Toplam ---> " + toplam);

Console.WriteLine("---------------------------------------");

// Ekrana kullanıcının verdiği bir değerden yine kullanıcının verdiği başka bir değere kadar olan bütün sayılardan 3'e tam bölünenleri yazdıran bir for döngüsü.

Console.WriteLine("Başlangıç değeri giriniz");
int baslangic = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bitiş değeri giriniz.");
int bitis = Convert.ToInt32(Console.ReadLine());

for (int i = baslangic; i < bitis; i++)
{
    if (i % 3 == 0)
        Console.WriteLine(i);
}

//Değerleri bitis ve baslangic olarak degil, sayi1 sayi2 olarak alıp büyüklük-küçüklük durumuna göre azdan çoka gitmesini sağlayabilirsiniz.
Console.WriteLine("---------------------------------------");

// 100'den 1'e kadar geriye doğru yazdırınız.

for (int i = 100; i > 1; i--)
{
    Console.WriteLine(i);
}