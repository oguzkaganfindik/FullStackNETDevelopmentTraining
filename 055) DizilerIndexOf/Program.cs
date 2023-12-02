
// Aranan bir elemanın hangi indexte olduğu bilgisini dönen metot.

int[] sayilar = { 3, 5, 7, 6, 22, 1, 6, -5 };


Console.WriteLine(Array.IndexOf(sayilar, 3));
Console.WriteLine(Array.IndexOf(sayilar, 5));
Console.WriteLine(Array.IndexOf(sayilar, 7));
Console.WriteLine(Array.IndexOf(sayilar, 22));

Console.WriteLine(Array.IndexOf(sayilar, 6)); // Dizide birden fazla bulunuyorsa, yalnızca ilk elemanın indexi ile ilgilenir.

Console.WriteLine(Array.IndexOf(sayilar, -1000)); // Dizide olmayan değer için -1 döner.


// LastIndexOf
Console.WriteLine(Array.LastIndexOf(sayilar, 6)); //  taramaya sondan başlar, ilk bulduğu değerin indexini yazdırır. ( Indexler yine soldan sağa 0'dan artarak sıralıdır, değişmez!)


// 1 ile 10 arasında 6 rastgele sayıdan oluşan bir dizi oluşturunuz.
// Kullanıcıya dizide değer sorgulatınız.
// var mı yoksa yok mu durumunu yazdırınız.

int[] rastgeleSayilar = new int[6];

Random rnd = new Random();

for (int i = 0; i < rastgeleSayilar.Length; i++)
{
    rastgeleSayilar[i] = rnd.Next(1, 10);
}

Console.WriteLine("-------------- TEST -----------");

foreach (var item in rastgeleSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------------------------------");

Console.WriteLine("Sorgulanacak değeri giriniz.");
int sorgu = Convert.ToInt32(Console.ReadLine());

if (Array.IndexOf(rastgeleSayilar, sorgu) != -1)
{
    Console.WriteLine("DİZİDE VAR");
}
else
{
    Console.WriteLine("DİZİDE YOK.");
}
