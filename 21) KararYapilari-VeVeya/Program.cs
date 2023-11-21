//Girilen bir sayı tek mi yoksa değil mi diye kontrol ediniz.

// && -> ve
// || -> veya

Console.WriteLine("Sayı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 1 || sayi % 2 == -1)
{
    Console.WriteLine("Tek Sayı");
}
else
{
    Console.WriteLine("Çift Sayı");
}
Console.WriteLine("--------------------------------------");

//2 aşama
// 1) Kullanıcıdan kayıt olmasını isteyiniz
// Kullanıcı adı ve şifre'yi ayrı ayrı alınız.

// 2) Kullanıcıya giriş yapması için isim ve şifre girmesini söyleyiniz

// Kayıt aşamasındaki veriler ve giriş aşamasındakiler eşleşiyorsa, girişe izin veriniz.