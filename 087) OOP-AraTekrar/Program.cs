// Bir hayvan class'ı olsun. Id, Ad, Tur, Yas bilgilerinden oluşsun.

// İçerisinde BilgileriGoster isimli bir metot olsun. O hayvana ait olan bütün bilgiler alt alta ekrana yazılsın.

// Nesneyi oluşturmanın 2 alternatif yolu olsun. Birincisi hiçbir parametre vermeden default. İkincisi Id, Ad, Tur, Yas bilgilerini parametre olarak göndererek oluşturma. // Constructor

// Ardından 2 adet hayvan nesnesi oluşturarak, BilgileriGoster metodunu tetikleyiniz.

using _087__OOP_AraTekrar;

Hayvan h1 = new Hayvan();

Hayvan h2 = new Hayvan(2, "Züzü", "Zürafa", 20);


h1.BilgileriGoster();
Console.WriteLine("-------------");
h2.BilgileriGoster();