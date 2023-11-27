// Ekrana 3 kere -> Hello World yazdırınız.

for(int sayac = 0; sayac < 3; sayac++)
{
    Console.WriteLine("Hello World");
}

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine("Merhaba");
}

//Ekrana 1'den 10'a kadar olan sayıları yazdır.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Ekrana 20 ile 60 arasındaki sayıları yazdırınız (20 ve 60 dahil)
for (int i = 20; i <= 60; i++)
{
    Console.WriteLine(i);
}

// Kullanıcıdan 5 kere veri isteyiniz. (string)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Bir veri giriniz.");
    Console.ReadLine();
}

// Ekrana 1 ile 15 arasında 7 tane rastgele sayı yazdırınız.

Random rnd = new Random();

for (int i = 0; i < 7; i++)
{
    Console.WriteLine(rnd.Next());
}