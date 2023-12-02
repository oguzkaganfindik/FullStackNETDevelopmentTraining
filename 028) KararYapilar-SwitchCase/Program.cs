
// KararYapilari-SwitchCase

// Kullanıcının girdiği sayınındeğeri 1 mi yoksa 2 mi yoksa 3-4-5'ten biri mi yoksa başka bir şey mi - bunu söyleyen bir karar yapısı.

Console.WriteLine("Kontrol etmek istediğiniz sayıyı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

switch (sayi)
{
    case 1:
        // sayı == 1 olma durumunda yapılacak işlemler buraya yazılır.
        Console.WriteLine("SAYINIZ 1");
        break;

    case 2:
        Console.WriteLine("SAYINIZ 2");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("SAYINIZ 3-4-5'TEN BİRİ");
        break;

    default:
        Console.WriteLine("SAYINIZ BAMBAŞKA BİR SAYI");
        break;
}




//if(sayi == 1)
//{
//    Console.WriteLine("Sayınız 1");
//}    
//else if (sayi == 2)
//{
//    Console.WriteLine("Sayınız 2");
//}
//else if (sayi == 3 || sayi == 4 || sayi == 5)
//{
//    Console.WriteLine("Sayı 3-4-5");
//}
//else
//{
//    Console.WriteLine("bambaşka");
//}


// Switch performans açısından if'ten daha performanslıdır çünkü tek atışta case ile eşleşir.

// Örneğin 4 sayısı girildiğinde IF - 3 kontrol yaparken , switch-case tek kontrol ile bulur.