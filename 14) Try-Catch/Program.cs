// Kullanıcıdan alınan 2 sayının toplamınu ekrana yazdırınız.

//Console.WriteLine("1. sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2. sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Sayıların toplamı -> " + (sayi1+sayi2));

try
{
    Console.WriteLine("1. sayıyı giriniz");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sayıların toplamı -> " + (sayi1 + sayi2));
}
catch (Exception)
{
    Console.WriteLine("Sayısal veriyi hatalı girdiniz!");
}

// Farklı hatalar için farklı işlemler yapmak istersek Catch (.....) kısmından istediğimiz kadar yazabiliriz.
// Çok fazla try-catch performans düşürür, uygulamayı yorar.

try
{

}
catch (FormatException) //spesifik bir hata
{

	throw;
}
catch (DivideByZeroException) //spesifik başka hata
{

    throw;
}