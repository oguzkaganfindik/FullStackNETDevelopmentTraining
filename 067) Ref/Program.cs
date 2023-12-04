void Metot1(string name)
{
    name = "Muhittin";
    Console.WriteLine(name);
}

void Metot2(ref string name)
{
    name = "Aladdin";
    Console.WriteLine(name);
}

Console.WriteLine("isminizi giriniz.");
string isim = Console.ReadLine();

Metot1(isim); //Muhittin
Console.WriteLine(isim); //Ajda

Metot2(ref isim); // Aladdin
Console.WriteLine(isim); // Aladdin

// ref kullanılmazsa -> işlemler değişkenin değerinin bir kopyası üzerinden gerçekleşir. Orijinalindekini verir metot içerisinde değişmez.

// ref kullanılırsa -> işlemler değişkenin kendisi üzerinden gerçekleşir, değişiklikler kalıcı etki yapar.