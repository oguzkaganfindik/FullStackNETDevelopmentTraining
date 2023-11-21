// Bir değişken tanımlayıp değerini konsol ekranından atayınız.

Console.WriteLine("Bir metin giriniz.");
string girilenMetin = Console.ReadLine();

// Kullanıcıya adını, soyadını sorunuz ve bu değerleri 2 ayrı değişkene atayınız.
// Ardından Hoş Geldin .... ...... şeklinde karşılayarak uygulamayı sonlandırınız.

Console.WriteLine("Adınızı giriniz.");
string ad = Console.ReadLine();

Console.WriteLine("Soyadınızı giriniz.");
string soyad = Console.ReadLine();

Console.WriteLine("Hoş Geldin " + ad + " " + soyad);