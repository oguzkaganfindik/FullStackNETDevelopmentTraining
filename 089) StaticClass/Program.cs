using _089__StaticClass;

// StaticClass

int sayi1 = 10;
int sayi2 = 20;

//Islemler islemler1 = new Islemler();

//islemler1.Topla(sayi1, sayi2);
//islemler1.Cikar(sayi1, sayi2);

//Console.WriteLine("-------------------");
//Islemler islemler2 = new Islemler();

//islemler2.Topla(sayi1, sayi2);
//islemler2.Cikar(sayi1, sayi2);

//Console.WriteLine("-------------------");
//Islemler Test = new Islemler();

//Test.Topla(sayi1, sayi2);
//Test.Cikar(sayi1, sayi2);

// Islemler üzerinden kaç tane nesne oluşturursak oluşturalım metotların çalışması değişmiyor. O halde anlıyorum ki class içerisindeki yapılar nesnelere bağımlı değil. Amaç yalnızca onları farklı bir sayfaya/alana almak.

// Böyle bir durumda class'ı ve metotları static yapıp, direkt class üzerinden erişim sağlanabilir.

//Islemler x = new Islemler(); static bir classtan nesne oluşmaz.

Islemler.Topla(sayi1, sayi2);


// STATIC CLASS İÇİN BİLİNDİK ÖRNEK ---> MATH


Console.WriteLine(FizikKutuphanesi.YerCekimiKuvveti); // read işlemi, property'nin Get metodunu tetikler.

Console.WriteLine(FizikKutuphanesi.kaldirmaKuvveti);

Console.WriteLine(FizikKutuphanesi.indirmeKuvveti);