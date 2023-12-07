// 1- Aşağıdaki çıktıyı yazan bir program.

// Merhaba
// nasılsın ?
// İyiyim
// Sen nasılsın ?

Console.WriteLine("Merhaba\nnasılsın ?\nİyiyim\nSen nasılsın ?");

Console.WriteLine("-------------------------------------------------------");


// 2- Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string metinselDegisken;
int tamSayiDegisken = 0;
metinselDegisken = "Bu bir metinsel değişkendir.";
tamSayiDegisken = 2023;
Console.WriteLine("metinsel değişken ekrana yazdırılıyor: " + metinselDegisken);
Console.WriteLine("tam sayı değişkeni ekrana yazdırılıyor: " + tamSayiDegisken);

Console.WriteLine("-------------------------------------------------------");

// 3- Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd1 = new Random();
int rastgeleSayi = rnd1.Next(0, 10000);
Console.WriteLine("Rastgele bir sayı üretildi: " + rastgeleSayi);

Console.WriteLine("-------------------------------------------------------");

// 4- Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Random rnd2 = new Random();
int sayi3 = rnd2.Next(0, 10000);
Console.WriteLine("Rastgele sayının 3'e bölümünden kalan: " + sayi3 % 3);

Console.WriteLine("-------------------------------------------------------");

// 5- Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.Write("Yaşınızı giriniz: ");
int kullaniciYas = Convert.ToInt32(Console.ReadLine());
if (kullaniciYas >= 18)
{
    Console.WriteLine("+");
}
else if (kullaniciYas < 18)
{
    Console.WriteLine("-");
}

Console.WriteLine("-------------------------------------------------------");

// 6- Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

string ekranaOnDefaYazdirilacakMetin = "Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(ekranaOnDefaYazdirilacakMetin);
}

Console.WriteLine("-------------------------------------------------------");

// 7- 10 adet tam sayı verisi alacak bir dizi tanımlayınız.

int[] sayilar = new int[10];

// 8- Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.

Random rnd3 = new Random();
int rastgeleSayiDizisiSayiUreteci = 0;

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rastgeleSayiDizisiSayiUreteci = rnd3.Next(0, 10000);
}

Console.WriteLine(" ----- 10 elemanlı sayı dizisi -----");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

// 9- Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

Console.WriteLine("11. Eleman olarak diziye eklemek istediğiniz yeni sayı nedir?");
int diziyeEklenecek = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar, sayilar.Length + 1);

sayilar[sayilar.Length - 1] = diziyeEklenecek;

// 10- Bu diziyi büyükten küçüğe ekrana yazdırınız.

Array.Sort(sayilar); // diziyi küçükten büyüğe sıralıyorum
Array.Reverse(sayilar); // diziyi ters çevirip büyükten küçüğe sıralanmış hale getiriyorum.

Console.WriteLine(" ----- 11 Elemanlı hale gelen sayı dizisi -----");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------------------------------");

// 11- Kullanıcıdan 2 tane metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
string MetinselDeger1 = "Gülse Birsel";
string MetinselDeger2 = "Demet Evgar";

Console.WriteLine("Metinsel değerlerin değiştirilmeden önceki hali: " + MetinselDeger1 + ", " + MetinselDeger2);
Console.WriteLine("2 Tane Metinsel Değer Giriniz: ");
string degisecekMetinselDeger1 = Console.ReadLine();
string degisecekMetinselDeger2 = Console.ReadLine();
Console.WriteLine("Girmiş olduğunuz metinsel değerlere göre " + MetinselDeger1 + " ve " + MetinselDeger2 + " değerleri değiştiriliyor");
MetinselDeger1 = MetinselDeger1.Replace(MetinselDeger1, degisecekMetinselDeger1);
MetinselDeger2 = MetinselDeger2.Replace(MetinselDeger2, degisecekMetinselDeger2);

Console.WriteLine("Metinsel değerlerin son hali: " + MetinselDeger1 + " , " + MetinselDeger2);

Console.WriteLine("-------------------------------------------------------");

// 12- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

Console.WriteLine("-------------------------------------------------------");

// 13- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

int SayilariTopla(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    return toplam;
}

Console.WriteLine("Birinci Sayıyı Giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = SayilariTopla(sayi1, sayi2);

Console.WriteLine("kullanıcıdan alınan İki sayının toplam değerinin geri döndürülmesinin sonucu: " + toplam);

Console.WriteLine("-------------------------------------------------------");

// 14- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string StringDegerDonenMetot(bool deger)
{
    return deger.ToString();
}

Console.WriteLine("true ya da false değer giriniz");
bool deger = Convert.ToBoolean(Console.ReadLine());
string sonuc = StringDegerDonenMetot(deger);

Console.WriteLine("string bir değer dönen bir metot sonucu : " + deger);

Console.WriteLine("-------------------------------------------------------");

// 15- 3 Kişinin yaşlarını alıo , en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

Console.WriteLine("1. kişinin yaşını giriniz");
int yas1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. kişinin yaşını giriniz");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. kişinin yaşını giriniz");
int yas3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("En Yaşlı Olanın Yaş Bilgisi " + EnYasliOlaniBulanMetot(yas1, yas2, yas3));

int EnYasliOlaniBulanMetot(int yas1, int yas2, int yas3)
{
    int enBuyuk = yas1;

    if (yas2 > enBuyuk)
    {
        enBuyuk = yas2;
    }

    if (yas3 > enBuyuk)
    {
        enBuyuk = yas3;
    }

    return enBuyuk;
}

Console.WriteLine("-------------------------------------------------------");

// 16- Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

int[] sinirsizSayiDizisi = SinirsizSayiAl();

int enBuyukSayi = EnBuyukSayiyiBul(sinirsizSayiDizisi);
Console.WriteLine("Girmiş olduğunuz sayılar içerisindeki En büyük sayı: " + enBuyukSayi);

static int[] SinirsizSayiAl()
{
    int[] sinirsizSayiDizisi = new int[0];

    while (true)
    {
        Console.WriteLine("Sayı giriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (Array.IndexOf(sinirsizSayiDizisi, sayi) == -1)
        {
            Array.Resize(ref sinirsizSayiDizisi, sinirsizSayiDizisi.Length + 1);
            sinirsizSayiDizisi[sinirsizSayiDizisi.Length - 1] = sayi;
        }

        Console.WriteLine("Başka bir sayı eklemek ister misiniz? (evet ise e yazıp enter'a basınız)");
        string cevap = Console.ReadLine();

        if (cevap != "e")
        {
            break;
        }
    }

    return sinirsizSayiDizisi;
}

int EnBuyukSayiyiBul(int[] dizi)
{
    Array.Sort(dizi);
    Array.Reverse(dizi);

    return dizi[0];
}

Console.WriteLine("-------------------------------------------------------");

//// 17- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.WriteLine("2 Tane İsim Giriniz: ");

Console.WriteLine("Birinci İsmi Giriniz: ");
string ad1 = Console.ReadLine();
Console.WriteLine("İkinci İsmi Giriniz: ");
string ad2 = Console.ReadLine();

Console.WriteLine("Girmiş olduğunuz İsimler: " + ad1 + ", " + ad2);

YerDegistir(ref ad1, ref ad2);

Console.WriteLine("Yerleri değişen isimlerin son hali: " + ad1 + " , " + ad2);

void YerDegistir(ref string ad1, ref string ad2)
{
    string araDegisken = ad1;
    ad1 = ad2;
    ad2 = araDegisken;
}

Console.WriteLine("-------------------------------------------------------");


// 18- Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

Console.WriteLine("Sayı giriniz: ");
int sayininDurumu = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SayiTekMiCiftMi(sayininDurumu));

bool SayiTekMiCiftMi(int sayininDurumu)
{
    if (sayininDurumu % 2 == 0)
        return true;

    return false;
}

Console.WriteLine("-------------------------------------------------------");

// 19- Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Hızı giriniz: ");
double hiz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Zamanı giriniz: ");
double zaman = Convert.ToDouble(Console.ReadLine());

double gidilenYol = GidilenYoluHesapla(hiz, zaman);

Console.WriteLine("Gidilen Yol: " + gidilenYol + " km");

double GidilenYoluHesapla(double hiz, double zaman)
{
    double gidilenYol = hiz * zaman;
    return gidilenYol;
}

Console.WriteLine("-------------------------------------------------------");

// 20- Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.WriteLine("Yarıçap bilgisi verilen bir dairenin alanı hesaplanacaktır");

Console.Write("bir yarıçap uzunluğu giriniz: ");
float yaricap = Convert.ToSingle(Console.ReadLine());
float daireninAlani = DaireAlaniniHesapla(yaricap);
Console.WriteLine("Dairenin alanı: " + daireninAlani);

float DaireAlaniniHesapla(float yaricap)
{
    float daireninAlani = (float)(Math.PI * Math.Pow(yaricap, 2));
    return daireninAlani;
}

Console.WriteLine("-------------------------------------------------------");

// 21- "Zamanb bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

Console.WriteLine("Zamanb bir GeRi SayIm" + " cümlesi hepsi büyük harf ve hepsi küçük harfle yazdırılacaktır.");

string cumle = "Zamanb bir GeRi SayIm";

Console.WriteLine("Cümlenin hepsini büyük harfle yazdırma: ");
Console.WriteLine(cumle.ToUpper());

Console.WriteLine("Cümlenin hepsini küçük harfle yazdırma: ");
Console.WriteLine(cumle.ToLower());

Console.WriteLine("-------------------------------------------------------");

// 22- "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string boslukSilinecek = "    Selamlar   ";
Console.WriteLine("Metnin boşlukları silinmemiş hali: " + boslukSilinecek);
Console.WriteLine("Metnin başındaki ve sonundaki boşluklar kalıcı olarak siliniyor: ");
string kaliciBoslukSilme = boslukSilinecek.Trim();
Console.WriteLine("Kalıcı olarak metindeki boşluklar silinmiştir. Metin yazdırılıyor: ");
Console.WriteLine(kaliciBoslukSilme);

Console.WriteLine("-------------------------------------------------------");

/* Alternatif Çözümler

// 1- Aşağıdaki çıktıyı yazan bir program.
// Merhaba
// nasılsın ?
// İyiyim
// Sen nasılsın ?

Console.WriteLine("Merhaba");
Console.WriteLine("nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");


// 2- Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string metinselDegisken = "burası bir metin.";
int tamSayiDegisken = 5;

Console.WriteLine(metinselDegisken);
Console.WriteLine(tamSayiDegisken);

// 3- Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();
Console.WriteLine(rnd.Next());


// 4- Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

int rastgele = rnd.Next();
int kalan = rastgele % 3;
Console.WriteLine( kalan ) ;


// 5- Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.WriteLine("Yaşınız kaç ?");
int yas = Convert.ToInt32(Console.ReadLine());

if(yas >= 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");

// ternary if ile yapsaydım
Console.WriteLine(yas >= 18 ? "+" : "-");

// ? -> if kısmı
// : -> else kısmı

// 6- Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

int sayac = 0;

while (sayac < 10 )
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
    sayac++;
}

// 7- 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
int[] sayilar = new int[10];

// 8- Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
   
}

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

// 9- Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

Console.WriteLine("Yeni değer giriniz.");
int yeni = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar, sayilar.Length + 1);
sayilar[sayilar.Length - 1] = yeni;

// 10- Bu diziyi büyükten küçüğe ekrana yazdırınız.

Array.Sort(sayilar); // küçükten büyüğe sırala.
Array.Reverse(sayilar); // ters çevir.

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}



// 11- Kullanıcıdan 2 tane metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

string isim1 = Console.ReadLine();
string isim2 = Console.ReadLine();

string gecici = isim1;
isim1 = isim2;
isim2 = gecici;

Console.WriteLine(isim1);
Console.WriteLine(isim2);

// 12- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma.");
}

BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();

// 13- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}


// 14- Parametre olarak true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string Test(bool durum)
{
    return durum ? "BAŞARILI" : "BAŞARISIZ";
}

// 15- 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int EnYasliyiBul(int yas1, int yas2, int yas3)
{

    int enyasli = yas1;

    if (yas2 > enyasli)
        enyasli = yas2;

    if (yas3 > enyasli)
        enyasli = yas3;

    return enyasli;
}

Console.WriteLine("En yaşlı olan -> " + EnYasliyiBul(15, 23, 11));

// 16- Parametre olarak alınan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

// int[] sayilar = {2, 3, 5, 11, 55, -3, -22, 59} metot kullanılınca params parametreleri buna dönüştürdü.

int enBuyuguBul(params int[] sayilar)
{
    Array.Sort(sayilar); // küçükten büyüğe sırala, en büyük değer en sonda kalır.

    Console.WriteLine("En büyük değer -> " + sayilar[sayilar.Length - 1]);

    return sayilar[sayilar.Length - 1];
}

enBuyuguBul(10, 30, 60, 11, -5, 23, 45, 1231);

// 17- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

void YerDegistir(ref string isim1, ref string isim2)
{
    string gecici = isim1;
    isim1 = isim2;
    isim2 = gecici;
}

string degisken1 = "Hellooo";
string degisken2 = "Good Bye";

YerDegistir(ref degisken1, ref degisken2);

Console.WriteLine(degisken1);
Console.WriteLine(degisken2);

// 18-  Parametre olarak alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

bool TekMi(int sayi)
{
    if (sayi % 2 != 0)
        return true;
    else
        return false;
}

// 19-  Parametre olarak alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

void YolHesapla(double hiz, double zaman)
{
    double gidilenYol = hiz * zaman;
    Console.WriteLine("Gidilen Yol ---> " + gidilenYol);
}

// 20- Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
void AlanHesapla(double yaricap)
{
    double alan = Math.PI * Math.Pow(yaricap, 2);
    Console.WriteLine("Dairenin alanı ---> " + alan);
}

// 21- "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string metin = "Zaman bir GeRi SayIm";

Console.WriteLine(metin.ToUpper());
Console.WriteLine(metin.ToLower());

// 22- "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string merhabaMetni = "    Selamlar   ";

merhabaMetni = merhabaMetni.Trim();
Console.WriteLine(merhabaMetni);

*/