// Kullanıcıya oyunun kuralları sorulacak

// Rastgele sayı hangi değer aralıklarında üretilsin?
// Sınırsız tahmin hakkı olsun.
// Doğru tahmin yapılırsa döngüden çıkılıp, "Tebrikler ..'ıncı tahminde bildiniz." yazılsın.
// Her tahminde, yanlış ise ekrana bunu bildirelim.

Console.WriteLine("Başlangıç değerini giriniz.");
int baslangic = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bitiş değerini giriniz.");
int bitis = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int rastgeleSayi = rnd.Next(baslangic, bitis);

int tahminSayisi = 0;

while (true)
{
    Console.WriteLine("Tahmininiz nedir?");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    tahminSayisi++;

    if (rastgeleSayi == tahmin)
    {
        Console.WriteLine("Doğru Tahmin. " + tahminSayisi + ". tahminde bildiniz!");
        break;
    }
    else
    {
        Console.WriteLine("Yeniden Deneyiniz.");
    }
}