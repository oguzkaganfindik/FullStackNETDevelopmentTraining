// Ternary If ----> ?

// Tek bir satırda hızlı bir şekilde karar vermek için kullanılır.

// Bir sayı alıp bunun 0'da büyük eşit veya küçük olduğunu söyleyiniz?

Console.WriteLine("Bir sayı giriniz. ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 0)
    Console.WriteLine("0 veya daha büyük.");
else
    Console.WriteLine("0'dan küçük.");

//EK -> Tek bir satır işlem varsa, scope açmayabiliriz.

// Ternary If Yolu
//Console.WriteLine("0 veya daha büyük.");
//Console.WriteLine("0'dan küçük.");
//ikisinden biri olacak

Console.WriteLine(sayi >= 0 ? "0 veya daha büyük. " : "0'dan küçük");

//Bu sayının çift olup olmama durumunu yazdırınız.

Console.WriteLine(sayi %2 == 0 ? "çift sayıdır." : "tek sayıdır");

// Aynı sayı için çift ve 10'dan büyük mü yoksa tersi durum mu, yazdırınız.

Console.WriteLine(sayi % 2 == 0 && sayi > 10 ? "Sayı çift ve 10'dan büyük" : "Sayı tek veya 10'dan küçük eşit");

//? sonrası -> true kısım
// : sonrası -> false kısım

