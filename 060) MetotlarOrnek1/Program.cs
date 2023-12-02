// Geriye "Dünyanın sonuna doğmuşum" metnini dönen bir metot.

string GununSozu()
{
    return "Dünyanın sonuna doğmuşum";
}

// Geriye 3.14 olarak pi sayısını dönen bir metot.

double PiSayisiSoyle()
{
    return 3.14;
}

// Geriye en çok dinlediğiniz 3 şarkının isimlerinin dizisini dönen bir metot

string[] SarkilariSoyle()
{
    string[] sarkilar = { "Kehribar", "Basit Numaralar", "Cevapsız Sorular" };

    return sarkilar;

    return new string[] { "Kehribar", "Basit Numaralar", "Cevapsız Sorular" };
    // Yukarıdaki ikisi aynı sonucu döner, biri değişken içerisinden biri diret olarak.
    // bu kodun silinik olmasının nedeni, üstteki returnde metottan çıkıldığından bu koda hiç bir zaman erişilemeyeceği.
}

// Metotları Kullanalım

// Günün sözü metodunu çağırınız.
Console.WriteLine(GununSozu());

Console.WriteLine("Pi sayısının değeri -> " + PiSayisiSoyle());

// Metodu kullanarak en çok dinlediğiniz 3 şarkıyı yazdırınız.

foreach (var item in SarkilariSoyle())
{
    Console.WriteLine(item);
}

// dizi dönerken 2. yazım şekli

string[] TestMetodu()
{
    return new string[] { "abc", "def", "ghi" };
}

int X()
{
    int sayi = 10;
    return sayi;
}