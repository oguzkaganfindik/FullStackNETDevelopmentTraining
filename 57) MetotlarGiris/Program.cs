
// METODUN TANIMLANMASI
void Karsila()
{
    Console.WriteLine("Merhaba.");
    Console.WriteLine("Hoş geldiniz.");
    Console.WriteLine("Sizlere nasıl yardımcı olabilirim?");
}



// METODUN ÇAĞRILMASI
Karsila();
Karsila();
Karsila();

Console.WriteLine("--------------------------------------");

// Bir sayı giriniz diyip kullanıcıdan bir sayı değeri alan metot tanımlayınız.

void SayiIste()
{
    Console.WriteLine("Bir sayı giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine());
}

SayiIste();



// 1'den 10'a kadar sayıları yazdıran bir metot tanımlayınız.

void Saydir()
{
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine(i);
    }
}

// metodu çağırınız / çalıştırınız / tetikleyiniz / kullanınız.

Saydir();


Console.WriteLine("-------------------------------------");

// Kullanıcıdan adını ve soyadını ayrı ayrı isteyip "Hoş Geldiniz .... ..... " şeklinde karşılayan bir metot tanımlayıp kullanınız.

void BilgileriAlVeKarsila()
{
    Console.WriteLine("Adınız nedir?");
    string ad = Console.ReadLine();

    Console.WriteLine("Soyadınız nedir?");
    string soyad = Console.ReadLine();

    Console.WriteLine("Hoş Geldiniz " + ad + " " + soyad);
}

BilgileriAlVeKarsila(); // tetikle.


// PARAMETRE -> Metoda dışarıdan gönderilen değerler.

// parametre olarak iki adet sayı alıp bunların toplamını ekrana yazdıran metot.

void Topla(int x, int y)
{
    int toplam = x + y;
    Console.WriteLine("SAYILARIN TOPLAMI --> " + toplam);
}

Topla(22, 15);

// Kullanıcıdan iki sayı alıp bu sayılarla Topla metodunu çalıştırınız.

Console.WriteLine("Birinci sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Topla(sayi1, sayi2);