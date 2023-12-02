//Girilen bir sayı tek mi yoksa değil mi diye kontrol ediniz.

// && -> ve
// || -> veya

//Console.WriteLine("Sayı giriniz.");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi % 2 == 1 || sayi % 2 == -1)
//{
//    Console.WriteLine("Tek Sayı");
//}
//else
//{
//    Console.WriteLine("Çift Sayı");
//}
//Console.WriteLine("--------------------------------------");

//2 aşama
// 1) Kullanıcıdan kayıt olmasını isteyiniz
// Kullanıcı adı ve şifre'yi ayrı ayrı alınız.

// 2) Kullanıcıya giriş yapması için isim ve şifre girmesini söyleyiniz

// Kayıt aşamasındaki veriler ve giriş aşamasındakiler eşleşiyorsa, girişe izin veriniz.

Console.WriteLine("Kayıt Alanı");

Console.WriteLine("Kullanıcı adı giriniz.");
string kullaniciAdi = Console.ReadLine();

Console.WriteLine("Şifrenizi giriniz.");
string sifre = Console.ReadLine();

Console.WriteLine("Kayıt başarıyla oluşturuldu.");

Console.WriteLine("Giriş alanı");

Console.WriteLine("Giriş yapmak istediğiniz kullanıcı adı giriniz. ");
string girisKullaniciAdi = Console.ReadLine();

Console.WriteLine("Giriş yapmak istediğiniz şifreyi giriniz");
string girisSifre = Console.ReadLine();

if (kullaniciAdi == girisKullaniciAdi && sifre == girisSifre)
{
    Console.WriteLine("Giriş başarıyla yapıldı");
}
else
{
    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
}