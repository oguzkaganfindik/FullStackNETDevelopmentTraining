string[] konuklar1 = new string[6];

konuklar1[0] = "Ajda";
konuklar1[1] = "Hande";
konuklar1[2] = "Funda";
konuklar1[3] = "Ebru";
konuklar1[4] = "Gülşen";
konuklar1[5] = "Hadise";

// Bir dizinin eleman sayısı / uzunluğu ---> dizininAdi.Length
Console.WriteLine(konuklar1.Length);

// Bir dizinin ilk elemanı ---> dizininAdi[0]
Console.WriteLine(konuklar1[0]);

// Bir dizinin son elemanı ---> dizininAdi[dizininAdi.Length-1]
Console.WriteLine(konuklar1[konuklar1.Length - 1]);

Console.WriteLine("-------------------------------------------");

// Bir diziyi yazdırmak ---> Bir dizinin elemanlarına tek tek ulaşıp, onların değerlerini yazdırmak.

Console.WriteLine("******* KONUKLAR *******");

for (int i = 0; i < konuklar1.Length; i++)
{
    Console.WriteLine(konuklar1[i]);
}

// Bir diziye konsoldan değer atamak istersek.

for (int i = 0; i < konuklar1.Length; i++)
{
    konuklar1[i] = Console.ReadLine();
}