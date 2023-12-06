using _079__Constructor;

// Constructor

// Doğum Tarihi - Ad - Soyad - Cinsiyet - Kilo bilgileri olan bir Bebek nesnesi oluşturunuz. Nesnenizin değişkeninin adı yeniDogan olsun.


Bebek yeniDogan = new Bebek();

// Default değerleri yazdıralım.

Console.WriteLine(yeniDogan.DogumTarihi); //01.01.0001 00.00.00 Constructor'a eklendiği için artık default değer DEĞİL
Console.WriteLine(yeniDogan.Ad); // null
Console.WriteLine(yeniDogan.Cinsiyet); // false
Console.WriteLine(yeniDogan.Kilo); // 0

// Bir class'ı NEW'lemek =  Nesne oluşturmak =  Instance almak ------> CONSTRUCTOR'ını tetiklemek.