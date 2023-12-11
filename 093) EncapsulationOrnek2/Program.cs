
// Kullanıcıdan Ad , Soyad, Telefon Numarası alınız.

// Telefon numarası uzunluğu 10'dan fazla veya eksikse numara 3 adet 0 atayınız.

// Telefon numarası kayıt aşamasında başına 0 eklemeyiniz.

// Telefon numarası okunmak istediğinde değeri başında 0 ile getiriniz.

// 5319301005 -> set
// 05319301005 -> get


using _093__EncapsulationOrnek2;

Kullanici kul = new Kullanici();

Console.WriteLine("Adınız nedir?");
kul.Ad = Console.ReadLine();

Console.WriteLine("Soyadınız nedir?");
kul.Soyad = Console.ReadLine();

Console.WriteLine("Telefon numaranız nedir? (başında 0 olmadan)");
kul.TelNo = Console.ReadLine();


Console.WriteLine("Kişinin telefon numarası -> " + kul.TelNo);