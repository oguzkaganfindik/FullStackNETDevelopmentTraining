// Bir kayıt ekranında kullanıcıdan veri isteyiniz. Email ve Şifre
// Ardından bu kullanıcının bilgilerini birer değişkene kayıt ediniz.

// Giriş kısmı için Kullanıcıya emailini sorunuz ve ad eşleşiyorsa, şifresini sorunuz. İkisi de eşleşiyorsa girişe izin veriniz.

// Email kontrolünde büyük küçük harf duyarlılığı olmasın.

// kayitliEmail -> AjdaPekkan@gmail.com
// girisEmail -> ajdapekkan@gmail.com

// KAYIT

Console.WriteLine("Email Bilginizi Giriniz.");
string kayitliEmail = Console.ReadLine();

Console.WriteLine("Şifrenizi Giriniz.");
string kayitliSifre = Console.ReadLine();

Console.WriteLine("Kaydınız Başarıyla Tamamlandı");

// GİRİŞ
Console.WriteLine("Giriş Yapacağınız Email Nedir?");
string girisEmail = Console.ReadLine();

if (kayitliEmail.ToUpper() == girisEmail.ToUpper())
{
    Console.WriteLine("Şifreniz Nedir?");
    string girisSifre = Console.ReadLine();

    if (girisSifre == kayitliSifre)
    {
        Console.WriteLine("Giriş Başarılı");
    }
}
else
{
    Console.WriteLine("Kullanıcı Bulunamadı");
}
