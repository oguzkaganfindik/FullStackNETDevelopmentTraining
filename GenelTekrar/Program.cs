// Ekrana Adınızı ve Soyadınızı yazdırınız.
Console.WriteLine("Ad" + " " + "Soyad");
// Ekrana "Şeytan diyor ki yanaş şuna" yazan bir kod.
Console.WriteLine("Şeytan diyor ki yanaş şuna");
/*
Zorluklar yolumdan çekiliyor.
Başarıya giden yolum düzleşiyor.
Sadece yürümeye devam etmeliyim.

Yukarıdaki çıktıyı tek bir Console.WriteLine() kullanarak yazınız.
*/
Console.WriteLine("Zorluklar yolumdan çekiliyor.\r\nBaşarıya giden yolum düzleşiyor.\r\nSadece yürümeye devam etmeliyim.");

// Console ekranından veri girilmesini sağlayan c# kodunu yazınız.
Console.WriteLine("klavyeden veri gir");
Console.ReadLine();
// RAM nedir, değişken nedir bir Console.WriteLine() içerisinde yazdırınız.
Console.WriteLine("Rastgele erişimli hafıza veya rastgele erişimli bellek (İng. İngilizce: Random Access Memory, RAM) mikroişlemcili sistemlerde kullanılan ve genellikle çalışma verilerini ve makine kodunu depolamak için kullanılan herhangi bir sırada okunabilen ve değiştirilebilen bir tür geçici veri deposudur.");
Console.WriteLine("Değişken (İng. variable), bilgisayar ve matematik biliminde sembolik bir ifade veya bir niceliği (miktarı) ifade etmek için kullanılan semboldür. Matematikte, değişken, sık sık bilinmeyen bir niceliğin (potansiyel değişiminin) tanımlanması için; bilgisayar biliminde ise, niceliğin depolanabileceği bir yer, alan ifade eder. ");
// Bir tamsayı, bir metinsel veri tutacak değişken tanımlayınız.
int tamSayi;
string metinselVeri;
// Bir adet float, bir adet decimal değişken tanımlayıp, bunlara 3.14 değerini atayınız.
float deger1 = 3.14F;
decimal deger2 = 3.14M;
// Bir adet float, bir adet decimal değişken tanımlayıp, bunlara konsol ekranından istenilen değerlerin atanmasını sağlayan kodu yazınız.
Console.WriteLine("Float değer giriniz: ");
float deger3 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Decimal değer giriniz: ");
decimal deger4 = Convert.ToDecimal(Console.ReadLine());
// Bir adet "yaş" değişkeni tanımlayıp kullanıcıdan yaşını girmesini isteyiniz ve bu değeri ekrana yazdırınız.
Console.WriteLine("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(yas);
// Kullanıcıdan 2 tam sayı alıp, bunların çarpımlarını ekrana yazdırınız.
Console.WriteLine("birinci tam sayıyı girin ");
int birinciTamSayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci tam sayıyı girin ");
int ikinciTamSayi = Convert.ToInt32(Console.ReadLine());
// Yer çekimi kuvvetini 10 olarak sabit bir değişkende tutunuz. (c# const kavramı araştırınız.)
const int g = 10;
// Kullanıcının girdiği bir sayının 3'e bölümünden kalanı ekrana yazdırınız.
Console.WriteLine("sayi girin? not: 3. katı bir sayı girerseniz kalan sıfır olacaktır.");
int uceBolumSayiGirin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(uceBolumSayiGirin % 3);

//Aşağıdaki Çıkıtıyı sağlayacak c# kodlarını yazınız.

//Adınız Nedir?
Console.WriteLine("Adınız Nedir?");
string adiniz = Convert.ToString(Console.ReadLine());
//Soyadınız Nedir?
Console.WriteLine("Soyadınız Nedir?");
string soyadiniz = Convert.ToString(Console.ReadLine());
//.....
//..... ...... isimli öğrenci için
//Vize Notu : ....
//Final Notu : ....
Console.WriteLine($"({adiniz} {soyadiniz} isimli öğrenci için");
Console.WriteLine("Vize Notu: ");
double vizeNotu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Final Notu: ");
double finalNotu = Convert.ToDouble(Console.ReadLine());
//Vizenin %40 - Finalin %60'ı alınarak hesaplanan ortalama ....
//not : Vize ve Final notları double olarak alınsın.
//.....'lı kısımlar console ekranından doldurulacak.
Console.WriteLine($"(Vizenin %40 - Finalin %60'ı alınarak hesaplanan ortalama: {vizeNotu*0.40+finalNotu*0.60}");
