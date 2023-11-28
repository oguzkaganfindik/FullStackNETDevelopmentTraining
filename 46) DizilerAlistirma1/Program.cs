// 5 Elemanlı bir Ogrenciler dizisi oluşturunuz.

// Ardından bu dizi içerisinde for ile dönerek konsol ekranında her bir elemanın değerini doldurunuz ( 1. öğrencinin adını giriniz - 2. öğrencinin adını ...)

// **** Öğrenciler **** diye bir başlık atıp, her elemanı tek tek listeleyiniz.

string[] ogrenciler = new string[5];

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine((i + 1) + " . öğrencinin adını giriniz.");
    ogrenciler[i] = Console.ReadLine();
}

Console.WriteLine("**** Öğrenciler ****");

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}