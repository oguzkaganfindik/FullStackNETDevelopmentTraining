// TekSayilar ve CiftSayilar olmak üzere 2 ayrı dizi oluşturunuz. 
// Kullanıcıdan sınırsız sayıda veri alınız. 
// Girilen değer tek ise tekSayilar dizisine, çift ise ciftSayilar dizisine gönderiyorsunuz.
// Fakat bir kural var, bir dizide aynı eleman birden fazla kere yazılamaz.
// Kullanıcı her sayı gönderdiğinde ve sayı diziye eklendiğinde veya eklenemediğinde (tekrar nedenli), "Başka bir sayı eklemek istiyor musunuz ? (Evet ise e tuşuna değil ise başka herhangi bir tuşa basınız)" diye bilgi veriniz.
// Eğer cevap e ise , işlem yeniden başlasın ve yeni bir sayı eklenilsin.
// Kullanıcı başka sayı eklemek istemezse, diziler ayrı ayrı yazdırılsın ve uygulama öyle sonlansın.

int[] tekSayilar = new int[0];
int[] ciftSayilar = new int[0];

while (true)
{
    Console.WriteLine("Eklemek istediğiniz sayıyı giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi % 2 == 0) // cift
    {
        if (Array.IndexOf(ciftSayilar, sayi) == -1)
        {
            Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
            ciftSayilar[ciftSayilar.Length - 1] = sayi;
        }
    }
    else // tek
    {
        if (Array.IndexOf(tekSayilar, sayi) == -1)
        {
            Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
            tekSayilar[tekSayilar.Length - 1] = sayi;
        }
    }

    Console.WriteLine("Başka bir sayı eklemek istiyor musunuz? (evet ise e gönder)");
    string cevap = Console.ReadLine();

    if (cevap != "e")
    {
        break; // döngüyü sonlandır demek ki başka veri girilmeyecek.
    }

}

Console.WriteLine("**** TEK SAYILAR ****");
foreach (var item in tekSayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("**** ÇİFT SAYILAR ****");
foreach (var item in ciftSayilar)
{
    Console.WriteLine(item);

}