// Kullanıcıdan 3 adet sayı alıp bunlardan en büyük olanın ve en küçük olanın değerlerini ekrana yazdırınız?

//Console.WriteLine("1. sayıyı girin");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. sayıyı girin");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3. Sayıyı girin");
//int sayi3 = Convert.ToInt32(Console.ReadLine());
//int eb;
//int ek;

//if (sayi1 > sayi2 && sayi1>sayi3)
//{
//    eb = sayi1;
//    if (sayi2 <  sayi3)
//    {
//        ek = sayi2;
//    }
//    else
//    {
//        ek = sayi3;
//    }
//}
//else if (sayi2 > sayi3 && sayi2>sayi1)
//{
//    eb = sayi2;
//    if (sayi1 < sayi3)
//    {
//        ek = sayi1;
//    }
//    else
//    {
//        ek = sayi3;
//    }
//}
//else
//{
//    eb = sayi3;
//    if (sayi1 < sayi2)
//    {
//        ek = sayi1;
//    }
//    else
//    {
//        ek = sayi3;
//    }
//}
//Console.WriteLine("En büyük sayi: " + eb);
//Console.WriteLine("En küçük sayi: " + ek);

// ya da;

//Console.WriteLine("1. sayıyı girin");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. sayıyı girin");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3. Sayıyı girin");
//int sayi3 = Convert.ToInt32(Console.ReadLine());

//int enBuyuk;
//int enKucuk;

//if (sayi1 > sayi2 && sayi1 > sayi3)
//{
//    enBuyuk = sayi1;
//}
//else if (sayi2 > sayi1 && sayi2 > sayi3)
//{
//    enBuyuk = sayi2;
//}
//else
//{
//    enBuyuk = sayi3;
//}

//if (sayi1 < sayi2 && sayi2 < sayi3)
//{
//    enKucuk = sayi1;
//}
//else if (sayi2 < sayi1 && sayi2 < sayi3)
//{
//    enKucuk = sayi2;
//}
//else
//{
//    enKucuk = sayi3;
//}

//Console.WriteLine("En küçük -> " + enKucuk);
//Console.WriteLine("En büyük -> " + enBuyuk);

//ya da

//Console.WriteLine("1. sayıyı girin");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. sayıyı girin");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3. Sayıyı girin");
//int sayi3 = Convert.ToInt32(Console.ReadLine());

//int enBuyuk = sayi1;
//int enKucuk = sayi1;

//if (sayi2 > enBuyuk)
//{
//    enBuyuk = sayi2;
//}
//if (sayi3 > enBuyuk)
//{ 
//    enBuyuk = sayi3; 
//}
//Console.WriteLine("En büyük -> " + enBuyuk);
//if (sayi2 < enKucuk)
//{
//    enKucuk = sayi2;
//}
//if (sayi3 < enBuyuk)
//{
//    enKucuk = sayi3;
//}
//Console.WriteLine("En küçük -> " + enKucuk);

//???

Console.WriteLine("1. Sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3. Sayıyı giriniz");
int sayi3 = Convert.ToInt32(Console.ReadLine());

int enBuyuk = sayi1;
int enKucuk = sayi1;

if (sayi2 > enBuyuk)
{
    enBuyuk = sayi2;
}
else if (sayi2 < enKucuk)
{
    enKucuk = sayi2;
}
if (sayi3 > enBuyuk)
{
    enBuyuk = sayi3;
}
else if (sayi3 < enKucuk)
{
    enKucuk = sayi3;
}

Console.WriteLine($"En büyük sayı => {enBuyuk}");
Console.WriteLine($"En küçük sayı => {enKucuk}");