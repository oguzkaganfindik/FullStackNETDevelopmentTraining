// 2 adet metot

// 1-> Parametre olarak 2 adet tamsayı alıp bunların çarpımlarını geriye dönen bir metot.

int SayilariCarp(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}

// 2-> Parametre olarak alınan bir sayının değerinin çift olup olmadığı bilgisini geriye dönen bir metot.

bool CiftMi(int sayi)
{
    if (sayi % 2 == 0)
        return true;

    return false;
}

// Konsol ekranından 2 adet sayı alıp bunları önce çarpma metoduna gönderiniz. Ardından çarpmadan gelen sonucu çift olup olmama metoduna gönderiniz. Metottan gelen true ya da false bilgisine göre ekrana tektir ya da çifttir yazdırınız.

Console.WriteLine("Birinci sayıyı giriniz.");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
int s2 = Convert.ToInt32(Console.ReadLine());

int sonuc = SayilariCarp(s1, s2);
Console.WriteLine(sonuc);

if (CiftMi(sonuc))
{
    Console.WriteLine("Çifttir.");
}
else
{
    Console.WriteLine("Tektir.");
}