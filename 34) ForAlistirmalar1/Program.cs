// FOR ile

// 1'den 10'a kadar olan sayıları (10 dahil) yazdırınız.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------------------------");

// -22'den 3'e kadar olan sayıları (3 dahil değil) yazdırınız.
for (int i = -22; i < 3; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------------------------");
// 10'dan 100'e kadar olan çift sayıları yazdırınız.
// 1. Yol

for (int i = 10; i <= 100; i++)
{
	if (i % 2 == 0)
        Console.WriteLine(i);
} //90 tur - 90 kontrol - 45 Console.WriteLine
Console.WriteLine("-------------------------------");
//2. Yol
for (int i = 10; i <= 100; i+=2)
{
    Console.WriteLine(i);
} //45 tur - 45 Console.WriteLine
Console.WriteLine("-------------------------------");