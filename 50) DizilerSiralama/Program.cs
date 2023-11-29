
int[] sayilar = { 22, 12, 50, -3, 5, -15, 15, 40 };

// BU SAYILARI KÜÇÜKTEN BÜYÜĞE ( ARTAN ) BİR ŞEKİLDE SIRALAYINIZ.

Array.Sort(sayilar);

Console.WriteLine("**** SAYILAR DİZİSİ ****");

foreach (var s in sayilar)
{
    Console.WriteLine(s);
}

// BU SAYILARI BÜYÜKTEN KÜÇÜĞE (AZALAN) SIRALAYINIZ.

// azalan sıralama metodu yok fakat siz bir diziyi artan olarak sıralayıp ters çevirirseniz azalan bir şekilde sıralamış olursunuz.
Array.Reverse(sayilar);

Console.WriteLine("**** SAYILAR DİZİSİ ****");

foreach (var s in sayilar)
{
    Console.WriteLine(s);
}
