//işlemler
// + toplama

//int sayi1 = 5, sayi2 = 10;
//int toplam = sayi1 + sayi2;

//Console.WriteLine("Sayıların toplamı -> " + (sayi1 + sayi2));
//Console.WriteLine("Sayıların toplamı -> " + toplam);

// - çıkarma
//int fark = sayi1 - sayi2;
//Console.WriteLine("Sayıların farkı -> " + fark);

// / bölme
//int bolum = sayi1 / sayi2;
//Console.WriteLine("Sayıların bölüm -> " + bolum);

// * çarpma
//int carpim = sayi1 * sayi2;
//Console.WriteLine("Sayıların çarpımı -> " + carpim);

// % mod (Bölümünden kalan)
//int bolumundenKalan = sayi1 % sayi2;
//Console.WriteLine("Sayi1'in Sayi2'ye bölümünden kalan -> " + bolumundenKalan);

//Console.WriteLine("--------------------------------------------------------------------");

// Kullanıcıya adını, soyadını, yaşını sorunuz ve bu değerleri birer değişkende tutunuz.
// Ardından kullanıcıdan 2 tane sayı girmesini isteyiniz (tip double)
// Ve ekrana
// .......... yaşındaki ......... .............. tarafından girilen iki sayı : ..... .......
// Sayıların çarpımı ..........
// şeklinde yazdırınız.

Console.Write("Adınızı girin: ");
string isim = Console.ReadLine();
Console.Write("Soyadınızı girin: ");
string soyisim = Console.ReadLine();
Console.Write("Yaşınızı girin: ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Birinci Sayı:");
double sayi1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("İkinci Sayı:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{yas} yaşındaki {isim} {soyisim} tarafından girilen iki sayı: {sayi1} ve {sayi2}'dir");
Console.WriteLine($"sayıların çarpımı {sayi1 * sayi2}");