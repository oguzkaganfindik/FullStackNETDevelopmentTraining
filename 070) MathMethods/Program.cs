// Math Methods

// .Net Framework içerisinde bir sürü kütüphane bulunuyor. Math kütüphanesi de bunlardan bir tanesi. İçerisinde bizim için hazırlan matematiksel işlemlerde işimizi kolaylaştıran metotlar bulunuyor.

// Yuvarlama işlemleri - pi sayısı - üs alma - kök alma vb.

// Pi sayısı okuma


double pi = Math.PI;
Console.WriteLine(pi);

// Alt sayıya tamamlama -> floor

Console.WriteLine("Alt sayıya tamamlamak istediğiniz değeri giriniz.");
double deger = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Floor(deger));

// Üst sayıya tamamlama -> ceiling

Console.WriteLine("Üst sayıyı tamamlamak istediğiniz değeri giriniz");
double deger2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Ceiling(deger2));

// yuvarlama

Console.WriteLine("Yuvarlamak istediğiniz değeri giriniz");
double deger3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(deger3));
Console.WriteLine("-----------------------------------");
Console.WriteLine(Math.Round(3.14));
Console.WriteLine(Math.Round(3.80));


Console.WriteLine(Math.Round(15.5));
Console.WriteLine(Math.Round(16.5));
Console.WriteLine(Math.Round(17.5));
// .5 ile yuvarlama durumlarında alt ve üst değere bakar, hangisi çift ise onu seçer.
Console.WriteLine("-----------------------------------");

// üs alma -> pow

Console.WriteLine(Math.Pow(4,2));
Console.WriteLine(Math.Pow(10,5));

// karekök alma -> sqrt
Console.WriteLine(Math.Sqrt(25));

Console.WriteLine("-----------------------------------");

// Kullanıcı tarafından girilen taban ve yükseklik ölçüleriyle bir dik üçgenin çevresini hesaplayan uygulama.

// Çevre hesapla: değerleri parametre olarak alan bir metot tarafından yapılacak.

// Hipotenüs -> karekök(Taban*taban + yukseklik*yukseklik)
double CevreHesapla(double taban, double yukseklik)
{
    double hipo = Math.Sqrt(Math.Pow(taban, 2) + Math.Pow(yukseklik, 2));
    return taban + yukseklik + hipo;
}

Console.WriteLine("Taban ölçüsünü giriniz.");
double taban = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Yükseklik ölçüsünü giriniz");
double yukseklik = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("üçgenin çevresi -> " + CevreHesapla(taban, yukseklik));