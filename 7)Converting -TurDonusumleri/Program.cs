// Converting - TurDonusumleri
// Kullanıcıya yaşınızı sorunuz ve bunu bir değişkende tutunuz.

Console.WriteLine("Lütfen yaşınızı giriniz");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yaş değeri kayıt edildi ---> " + yas);

Console.WriteLine("----------------------------------------");

// Kullanıcıdan double ve float olmak üzere 2 adet sayı isteyiniz ve değişkene arayınız.

Console.WriteLine("Double sayı giriniz?");
double doubleSayi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Girilen değer -> " + doubleSayi);

Console.WriteLine("Float sayı giriniz?");
float floatSayi = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Girilen değer -> " + floatSayi);