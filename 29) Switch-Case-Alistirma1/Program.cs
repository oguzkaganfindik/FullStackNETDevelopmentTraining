
// Kullanıcıdan bir sayı alıp haftanın hangi gününde olduğunu söyleyiniz.

Console.WriteLine("Haftanın kaçıncı günündesiniz?");
int gunSayisi = Convert.ToInt32(Console.ReadLine());

switch (gunSayisi)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;

    case 2:
        Console.WriteLine("Salı");
        break;

    case 3:
        Console.WriteLine("Çarşamba");
        break;

    case 4:
        Console.WriteLine("Perşembe");
        break;

    case 5:
        Console.WriteLine("Cuma");
        break;

    case 6:
        Console.WriteLine("Cumartesi");
        break;

    case 7:
        Console.WriteLine("Pazar");
        break;

    default:
        Console.WriteLine("ÖYLE BİR SAYIYLA EŞLEŞEN GÜN YOK !");
        break;
}



Console.WriteLine("-------------------------------------------");
// Kullanıcıdan bir ay ismi alıp hangi mevsimde olduğunu söyleyiniz.


Console.WriteLine("Hangi aydasınız?");
string ayIsmi = Console.ReadLine();

switch (ayIsmi)
{
    case "Aralık":
    case "Ocak":
    case "Şubat":
        Console.WriteLine("KIŞ");
        break;

    case "Mart":
    case "Nisan":
    case "Mayıs":
        Console.WriteLine("İLKBAHAR");
        break;

    case "Haziran":
    case "Temmuz":
    case "Ağustos":
        Console.WriteLine("YAZ");
        break;

    case "Eylül":
    case "Ekim":
    case "Kasım":
        Console.WriteLine("SONBAHAR");
        break;

    default:
        Console.WriteLine("Tanımlı olmayan bir değer girdiniz.");
        break;
}