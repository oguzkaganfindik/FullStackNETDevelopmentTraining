// Array / Dizi -> Bir kolleksiyon yapıdır. AYNI TİPTE birden fazla değeri bir arada tutmak için kullanılır. Ram'de heap tarafında bulunur.

int sayi1 = 4;
int sayi2 = 7;
int sayi3 = 15;

int[] sayilar = new int[3];
// Tip[] adi = new Tip[elemanSayisi];

sayilar[0] = 4;
sayilar[1] = 7;
sayilar[2] = 15;

// 3 ayrı değişkende 3 farklı sayı tutmaktansa, tek bir değişken olan dizide, aynı alanda 3 değeri tutuyorum.

Console.WriteLine(sayilar);

Console.WriteLine(sayilar[0]);
Console.WriteLine(sayilar[1]);
Console.WriteLine(sayilar[2]);

// Atanacak değerler en baştan belliyse kullanılabilecek yöntem.

int[] x = { 3, 20, 15, 14, 7, 2, 5 };

Console.WriteLine("-----------------------------------");

// Bir gala gecesi için konuklar listemiz var.

// 2 dizi oluşturma yöntemiyle de oluşturalım. (konuklar1 - konuklar2)
// Katılacaklar -> Ajda, Hande, Funda, Ebru, Gülşen, Hadise

string[] konuklar1 = new string[6];

konuklar1[0] = "Ajda";
konuklar1[1] = "Hande";
konuklar1[2] = "Funda";
konuklar1[3] = "Ebru";
konuklar1[4] = "Gülşen";
konuklar1[5] = "Hadise";

string[] konuklar2 = { "Ajda", "Hande", "Funda", "Ebru", "Gülşen", "Hadise" };