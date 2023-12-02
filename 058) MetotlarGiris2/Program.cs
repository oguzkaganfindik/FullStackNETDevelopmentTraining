// METOTLAR

// Void -> Bir metodun geriye değer dönmediği durumlardaki tipidir.

// Array.IndexOf(sayilar, 5); -> Geriye değer döndüren metot örneği (Geriye değer döndürdüğünden dolayı Void değil)

// Ekrana merhaba yazanan bir metot. (MerhabaYaz)

using System.Threading.Channels;

void MerhabaYaz()
{
    Console.WriteLine("Merhaba");
}

MerhabaYaz();
MerhabaYaz();
MerhabaYaz();
MerhabaYaz();

// Kişinin ismini parametre olarak alıp o kişiye merhaba diyen metot.

void KişiyeMerhabaDe(string isim)
{
    Console.WriteLine("Merhaba " + isim);
}

KişiyeMerhabaDe("Oğuz");

// Parametre olarak isim + soyisim + yaş bilgilerini alıp kişinin tüm bilgilerini tek tek ekrana yazdıran bir metot.

void  KisiBilgileriYazdir(string isim, string soyisim, int yas)
{
    Console.WriteLine("Kişinin ismi -> " + isim);
    Console.WriteLine("Kişinin soyismi -> " + soyisim);
    Console.WriteLine("Kişinin yaşı -> " + yas);
}

// Yukarıdaki metodu hem statik verilerle hem de konsol ekranından alınan verilerle çalıştırınız.

// statik veri
KisiBilgileriYazdir("Ajda", "Pekkan", 50);

// Konsol'dan yazdırma:

Console.WriteLine("isminiz nedir?");
string isim = Console.ReadLine();

Console.WriteLine("Soyisminiz Nedir?");
string soyisim = Console.ReadLine();

Console.WriteLine("Yaşınız Kaç?");
int yas = Convert.ToInt32(Console.ReadLine());

KisiBilgileriYazdir(isim, soyisim, yas);

Console.WriteLine("---------------------------------");

// Kullanıcıdan aldığınız 2 sayıyı Topla isimli bir metota gönderip, değerlerin toplamını ekrana yazdırınız.

// Metodun görevi yalnızca parametre olarak alınan 2 sayıyı toplamak.

// Değerleri konsol ekranından almak metodun görevi olarak tanımlanmamış.

void Topla(int s1, int s2)
{
    int toplam = s1 + s2;
    Console.WriteLine("Sayıların toplamı -> " + toplam);
}

Console.WriteLine("Birinci sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Topla(sayi1, sayi2);

// 2-> Hem değerleri konsol ekranından alan hem de sayılar toplamını yazdıran bir Topla2 metodu tanımlayınız.

void Topla2()
{
    Console.WriteLine("Birinci sayıyı giriniz.");
    int s1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı giriniz");
    int s2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sayıların toplamı -> " + (s1 + s2));
}
// metodu çağırış
Topla2();