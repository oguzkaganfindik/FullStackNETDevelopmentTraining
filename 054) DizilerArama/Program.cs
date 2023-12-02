
int[] sayilar = { 15, 10, 8, 5, 7, 5, 20, -4, -1, 5, 40, 22 };

// Kullanıcının girdiği bir sayı dizide var mı var ise kaç tane var yazdıran kod.

Console.WriteLine("Sorgulamak istediğiniz değer nedir?");
int sorgulanacak = Convert.ToInt32(Console.ReadLine());

int kacTane = 0;

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] == sorgulanacak)
    {
        kacTane++;
    }
}

if (kacTane == 0)
{
    Console.WriteLine("DİZİDE YOK");
}
else
{
    Console.WriteLine("Dizide -> " + kacTane + " tane var.");
}