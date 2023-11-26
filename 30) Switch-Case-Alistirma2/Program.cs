
// Kullanıcıdan double tipinde 2 adet sayı isteyiniz.

// Kullanıcıdan char tipinde bir işlem türü isteyiniz. ( + , - , / , *)

// Ardından switch-case ile sonucu ekrana yazdırınız.



Console.WriteLine("Birinci sayıyı giriniz.");
double s1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
double s2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hangi işlemi yapmak istersiniz ? ( + , - , * , / )");
char islem = Convert.ToChar(Console.ReadLine());


switch (islem)
{
    case '+':
        Console.WriteLine("Sayıların toplamı -> " + (s1 + s2));
        break;

    case '-':
        Console.WriteLine("Sayıların farkı -> " + (s1 - s2));
        break;

    case '*':
        Console.WriteLine("Sayıların çarpımı -> " + (s1 * s2));
        break;

    case '/':
        Console.WriteLine("Sayıların bölümü -> " + (s1 / s2));
        break;

    default:
        Console.WriteLine("ÖYLE BİR İŞLEM YOOOK !");
        break;
}




