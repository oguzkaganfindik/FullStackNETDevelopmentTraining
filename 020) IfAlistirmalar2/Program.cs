//Kullanıcı tarafından girilen bir sayının tek mi yoksa çift mi olduğunu söyleyen bir karar yapısı.

Console.Write("Sayi girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi %2 == 0)
{
    Console.WriteLine("Çift sayı girdiniz");
}
else
{
    Console.WriteLine("Tek sayı girdiniz");
}
Console.WriteLine("---------------------------------------");
//---- Aynı kontrolü tek mi başlığı altında yapalım (2'ye bölümünden kalan 1 mi? bu değilse bir de 2'ye bölümünden kalan -1'mi? hiçbiri değilse çifttir.
Console.Write("Sayi girin: ");
int tekMi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 1)
{
    Console.WriteLine("Tek sayı girdiniz");
}
if (sayi % 2 == -1)
{
    Console.WriteLine("Tek sayı girdiniz");
}
else
{
    Console.WriteLine("Çift sayı girdiniz");
}