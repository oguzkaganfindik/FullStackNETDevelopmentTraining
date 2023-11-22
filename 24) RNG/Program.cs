// RNG -> Random Number Generator

Random rnd = new Random();

rnd.Next();

Console.WriteLine(rnd.Next());

int rastgeleSayi = rnd.Next();
Console.WriteLine(rastgeleSayi);

int rastgele = rnd.Next(1,11); //1'den 11'e kadar(11 dahil değil)
Console.WriteLine(rastgele);
Console.WriteLine("------------------------------------------");
// Bir rastgele tahmin etme oyunu yapınız.

Console.WriteLine("Rastgele sayı oyununa hoş geldiniz...");

Random r = new Random();
int uretilenRastgeleSayi = r.Next(1, 11);

Console.WriteLine("Tahmininiz nedir?");
int tahmin = Convert.ToInt32(Console.ReadLine());

if (uretilenRastgeleSayi == tahmin)
{
    Console.WriteLine("Doğru Tahmin");
}
else
{
    Console.WriteLine("Olmadı");
}