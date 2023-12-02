
// While Kullanarak

// Ekrana 10 kere "Yaşasın tatil değil" yazan bir döngü.

int sayac = 0;
while (sayac < 10)
{
    Console.WriteLine("Yaşasın tatil değil.");
    sayac++;
}
Console.WriteLine("--------------------------------------------");
// 2 ile 10 arasında sayıları ekrana yazan döngü.

int i = 2;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("--------------------------------------------");
// -15 ile 3 arasındaki sayıların toplamını ekrana yazan bir döngü.

int j = -15;
int toplam = 0;

while (j < 4)
{
    toplam += j;
    j++;
}
Console.WriteLine("Toplam ----> " + toplam);

Console.WriteLine("--------------------------------------------");
// Ekrana 5 adet rastgele sayı yazan bir döngü.

Random x = new Random();
int k = 0;

while (k < 5)
{
    Console.WriteLine(x.Next(1, 10));
    k++;
}


Console.WriteLine("--------------------------------------------");
// Ekrandan sınırsız sayı alan ve kullanıcının girdiği her bir 1 değerini sayan bir döngü. (her 1 tuşuna basıldığında, bu bastığınız ....ncı 1 diye yazılacak)

int birSayaci = 0;
while (true)
{
    Console.WriteLine("Sayı giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Girdiğiniz sayı: " + sayi);

    if (sayi == 1)
    {
        birSayaci++;
        Console.WriteLine("Bu girdiğiniz " + birSayaci + ". 1 değeri!");
    }
}

Console.WriteLine("--------------------------------------------");

// Sonsuz sayıda sayı alınız, -1 değeri girildiğinde döngüden çıkınız.

while (true)
{
    Console.WriteLine("Sayı giriniz:");
    int s = Convert.ToInt32(Console.ReadLine());

    if (s == -1)
    {
        break;
    }
}

Console.WriteLine("--------------------------------------------");