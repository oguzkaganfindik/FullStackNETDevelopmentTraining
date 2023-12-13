
// Bir liste oluşturalım

// Sinema Filmleri listelenecek

// Film -> Imdb Puanı (double) - Ismi

// Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.

// Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun.

// 1 -> Bütün filmler listelensin.

// 2 -> Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.

// 3 -> İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.

using _104__ListOrnek.Models;

List<Film> filmler = new List<Film>();

while (true)
{
    Film yeniFilm = new Film();

    Console.WriteLine("Eklemek istediğiniz filmin adını giriniz.");
    yeniFilm.Isim = Console.ReadLine();

    Console.WriteLine("Eklemek istediğiniz filmin imdb puanını giriniz.");
    yeniFilm.ImdbPuani = Convert.ToDouble(Console.ReadLine());

    filmler.Add(yeniFilm);

    Console.WriteLine("Yeni bir eklemek istiyorsanız e harfi giriniz, istemiyorsanız başka bir şey girebilirsiniz.");
    string cevap = Console.ReadLine();

    if (cevap != "e")
    {
        break;
    }
}

Console.WriteLine("----- BÜTÜN FİLM İSİMLERİ -------");
foreach (var item in filmler)
{
    Console.WriteLine(item.Isim);
}

Console.WriteLine("------ IMDB PUANI 4 İLE 9 ARASI FİLMLER ------- ");
foreach (var item in filmler)
{
    if (item.ImdbPuani >= 4 && item.ImdbPuani <= 9)
        Console.WriteLine(item.Isim);
}

Console.WriteLine("---- A/a İLE BAŞLAYANLAR -----");
foreach (var item in filmler)
{
    if (item.Isim[0] == 'A' || item.Isim[0] == 'a')
        Console.WriteLine(item.Isim);
}
