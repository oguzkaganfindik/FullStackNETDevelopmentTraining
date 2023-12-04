// String Methods
// Metinsel yapılarda kullanılabilecek metotlar.

Console.WriteLine("Örnek bir metin giriniz");
string ornekMetin = Console.ReadLine();

// CompareTo -> iki metni kıyaslar, geriye -1, 0, 1 değerlerini döner.

int sonuc = ornekMetin.CompareTo("Merhaba");

if (sonuc == 0)
{
    Console.WriteLine("Aynı Metin");
}
else if (sonuc == -1)
{
    Console.WriteLine("Alfabetik olarak daha önce");
}
else
{
    Console.WriteLine("Alfabetik olarak daha sonra");
}

// Contains -> Metin içerisinde geçiyor mu yoksa geçmiyor mu?
// return ->>>>> true/false

bool varMi = ornekMetin.Contains("Sezen");
Console.WriteLine(varMi ? "Metinde geçiyor" : "Metinde geçmiyor");

// StartsWith - EndsWith

bool basliyorMu = ornekMetin.StartsWith("Ajda");
bool bitiyorMu = ornekMetin.EndsWith("Pekkan");

// Bir metni sorguladığımızda, evet bu kelime ile başlıyor ya da hayır bu kelime ile başlamıyor yazan ternary If kodlayınız.

Console.WriteLine(basliyorMu ? "Evet bu kelime ile başlıyor" : "Hayır bu kelime ile başlamıyor");

// Bir metni sorguladığımızda, evet bu kelime ile bitiyor ya da hayır bu kelime ile bitmiyor yazan ternary If kodlayınız.

Console.WriteLine(bitiyorMu ? "Evet bu kelime ile bitiyor" : "Hayır bu kelime ile bitmiyor");

Console.WriteLine("--------------------------------------------------");

// Substring -> Bir metinden alt parça alabilirsiniz.

string OrnekMetin2 = "Teoman";
Console.WriteLine(OrnekMetin2.Substring(2)); // oman
Console.WriteLine(OrnekMetin2.Substring(1, 4)); // eoma

// Kullanıcıdan bir telefon numarası isteyiniz. Girilen değer 0 ile başlıyorsa 0'ı atarak yeni bir metin oluşturup o numaranın kaydedildiğini kullanıcıya söyleyiniz. 0 ile başlamıyorsa, direkt girilen numara kaydedildi olarak söyleyiniz.

Console.WriteLine("Telefon numarası giriniz");
string no = Console.ReadLine();
if (no[0] == '0')
{
    no = no.Substring(1);
}
// else durumunda yapılacak bir şey yok. numara zaten 0'sız.
Console.WriteLine(no + " --> Kaydedildi.");

// Replace() ->> Metinde karakterleri değiştirmeye yarar.

string degisecekMetin = "Yirmi yaşında da olsa, seksen yaşında da olsa öğrenmesine son veren bir insan yaşlıdır. Öğrenmeye devam edense genç kalır. Hayattaki en güzel şey zihni genç tutmaktır.";

degisecekMetin = degisecekMetin.Replace("Yirmi", "Onbeş");

// Gerçekten değeri değiştirmek istiyorsak, eski değerin üzerine yazmamız gerekiyor.

Console.WriteLine(degisecekMetin);

// Bütün boşlukları siliniz.
degisecekMetin = degisecekMetin.Replace(" ", "");
Console.WriteLine(degisecekMetin);

// Trim() -> Baştaki ve sondaki boşlukları siler.

Console.WriteLine("Bir metin giriniz");
string yeniMetin = Console.ReadLine();

Console.WriteLine(yeniMetin);
Console.WriteLine(yeniMetin.Trim()); // kalıcı değişiklik yapmaz.
// kalıcı ->>>
yeniMetin = yeniMetin.Trim();

// ToLower - ToUpper

Console.WriteLine(yeniMetin.ToLower());
Console.WriteLine(yeniMetin.ToUpper());
// kalıcı değişiklik yapmaz!