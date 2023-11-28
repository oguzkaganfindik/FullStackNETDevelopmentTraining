// Kullanıcının istediği elemanlı string ifadelerden oluşan bir dizi oluşturunuz (meyveler)

Console.WriteLine("Kaç elemanlı bir dizi istiyorsunuz?");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());
string[] meyveler = new string[elemanSayisi];

// konsol ekranından sorarak bu diziyi doldurunuz.
for (int i = 0; i < meyveler.Length; i++)
{
    Console.WriteLine("Hangi meyveyi eklemek istersiniz? ");
    meyveler[i] = Console.ReadLine();
}

// dizinin uzunluğunu, ilk elemanını, son elemanını tek tek yazdırınız.

Console.WriteLine("Dizinin uzunluğu -> " + meyveler.Length);
Console.WriteLine("İlk eleman -> " + meyveler[0]);
Console.WriteLine("Son eleman -> " + meyveler[meyveler.Length-1]);

// diziyi yazdırınız.

for (int i = 0; i < meyveler.Length; i++)
{
    Console.WriteLine(meyveler[i]);
}

// dizinin içerisinde "Armut" var mı kontrol edip yazdırınız.

bool varMi = false;

for (int i = 0; i < meyveler.Length; i++)
{
    if (meyveler[i] == "Armut")
    {
        varMi = true;
    }
}

if (varMi) // == true yazmaya gerek yok.
{
    Console.WriteLine("Armut var");
}
else
{
    Console.WriteLine("Armut yok.");

}