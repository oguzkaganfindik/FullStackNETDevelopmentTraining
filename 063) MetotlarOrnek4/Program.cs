// 1 - Parametre olarak 2 adet sayı ve bir char değer alıp (Char -> işlem) , istenilen işlemi yapıp sonucu dönen metot.

double IslemYap(double sayi1, double sayi2, char islem)
{
    double sonuc = 0;
    if (islem == '+')
        sonuc = sayi1 + sayi2;
    else if (islem == '-')
        sonuc = sayi1 - sayi2;
    else if (islem == '/')
        sonuc = sayi1 / sayi2;
    else if (islem == '*')
        sonuc = sayi1 * sayi2;
    else
        Console.WriteLine("Tanımlı olmayan bir işlem");

    return sonuc;
}

double geriDonen = IslemYap(5, 15, '*');
Console.WriteLine(geriDonen);
Console.WriteLine("------------------------------");

// 2 - Parametre olarak isim ve soyisim bilgisi alıp aralarına boşluk yerleştirerek tek bir string ifade olarak geriye dönen metot.

string Birlestir(string ad, string soyad)
{
    return ad + " " + soyad;
}
Console.WriteLine(Birlestir("Sezen", "Aksu"));
Console.WriteLine("------------------------------");


// 3 - Parametre olarak yaş bilgisi alıp kişi 18 yaşından büyükse true , değilse false bilgisini geri dönen, aynı zamanda da ekrana bu bilgiyi ( Reşit ya da değil) yazdıran bir metot yazınız. Ardından uygulama tarafında bu metottan gelen true false bilgisine göre "Giriş yapabilir" veya "Giriş yapamaz" yazdırınız.

bool Kontrol(int yas)
{
    if (yas > 18)
    {
        Console.WriteLine("Reşit");
        return true;
    }
    else
    {
        Console.WriteLine("Reşit Değil");
        return false;
    }
}

if (Kontrol(20))
{
    Console.WriteLine("Giriş Yapabilir.");
}
else
{
    Console.WriteLine("Giriş Yapamaz, Yaşı küçük.");
}