// 100 -> A+
// 90-99 -> A
// 80-89 -> B
// 70-79 -> C
// 60-69 -> D
// 60--> (TEKRAR)

// Öğrenciden vize ve final notu isteyiniz. Hard notunu ekrana yazdırınız. (vize %40 - final %60)


Console.WriteLine("Vize notu giriniz");
double vize = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Final notu giriniz");
double final = Convert.ToDouble(Console.ReadLine());

double ortalama = vize * 0.40 + final * 0.60;

if (ortalama == 100)
{
    Console.WriteLine("A+");
}
else if (ortalama >= 90)
{
    Console.WriteLine("A");
}
else if (ortalama >= 80)
{
    Console.WriteLine("B");
}
else if (ortalama >= 70)
{
    Console.WriteLine("C");
}
else if (ortalama >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("TEKRAR");
}