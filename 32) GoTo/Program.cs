// GoTo

// Program akışında istediğimiz bir kod satırına sıçramak için kullanılan yapı.
/*
baslangic: Console.WriteLine("Bir sayı giriniz."); //satıra bir isim veriyorum, goto keyword'ü kullanarak kodların çalışmasını bu noktadan devam ettirebilirim.
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girdiğiniz sayı ----> " + sayi);

goto baslangic; //başlangıç diye isimlendirilmiş satıra git.
*/

//kullanıcıdan 2 adet sayı alarak, birinci sayıyı ikinci sayıya bölünüz. Eğer 2. sayı 0 girildiyse, böyle bir bölme işlemi yapamayacağınızı söyleyerek yeniden bir 2. sayı isteyiniz.

Console.WriteLine("Birinci sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

bolenSayi: Console.WriteLine("İkinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi2 == 0)
{
    Console.WriteLine("Bölemem!");
    goto bolenSayi;
}
Console.WriteLine("Sonuç --> + " + sayi1/sayi2);



