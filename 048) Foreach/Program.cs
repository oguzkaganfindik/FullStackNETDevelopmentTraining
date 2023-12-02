// 6 elemanlı bir davetliler dizisi oluşturun. Elemanları ekleyiniz.

string[] davetliler = new string[6];

for (int i = 0; i < davetliler.Length; i++)
{
    Console.WriteLine("Davetli adı giriniz.");
    davetliler[i] = Console.ReadLine();
}

Console.WriteLine("----- YAZDIRMA KISMI -----");

foreach (var item in davetliler)
{
    Console.WriteLine(item);
}

// var -> bir değişken tipi değildir. Atanan değere bakarak hangi tip olduğunu tahmin edip o şekilde çalıştırır.

// var x = "oğuz";
// var y = 25;
// var z = true;