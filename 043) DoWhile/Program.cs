// Do-While Döngüsü


int i = 0;
do
{
    Console.WriteLine("Buraya Bak");
    i++;
} while (i<5);
Console.WriteLine("------------------------------");

int j = 100;
do
{
    Console.WriteLine("Dikkat!");
    j++;
} while (j < 0);
Console.WriteLine("------------------------------");

// Do while ile sayı tahmin oyunu.

Random rnd = new Random();

int rastgele = rnd.Next(1, 10);
int tahmin;

do
{
    Console.WriteLine("Tahmininiz nedir?");
    tahmin = Convert.ToInt32(Console.ReadLine());

} while (rastgele != tahmin);

Console.WriteLine("Doğru tahmin");