
//Kullanıcının istediği sayıda rastgele sayıdan oluşan bir dizi tanımlayınız.

//Bu dizinin bütün elemanlarını foreach döngüsü ile yazdırınız.

//Console.WriteLine("Kaç elemanlı bir dizi istersiniz?");
//int elemanSayisi = Convert.ToInt32(Console.ReadLine());

//int[] sayilar = new int[elemanSayisi];

//Random rnd = new Random();

//for (int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = rnd.Next(1, 101);
//}

//foreach (var item in sayilar)
//{
//    Console.WriteLine(item);
//}

//Kullanıcının istediği sayıda rastgele sayıdan oluşan bir dizi tanımlayınız.

//Bu dizinin bütün elemanlarını foreach döngüsü ile yazdırınız.

// Aynı rastgele sayı 2 kere eklenmesin.

Console.WriteLine("Kaç elemanlı bir dizi istersiniz?");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[elemanSayisi];
Random rnd = new Random();

for (int i = 0; i < sayilar.Length; i++)
{
    int rastgeleSayi;
    bool sayiVar = false;

    do
    {
        rastgeleSayi = rnd.Next(1, 11);
        sayiVar = false;

        for (int j = 0; j < i; j++)
        {
            if (sayilar[j] == rastgeleSayi)
            {
                sayiVar = true;
                break;
            }
        }

    } while (sayiVar);

    sayilar[i] = rastgeleSayi;
}

Console.WriteLine("Oluşturulan Dizi:");

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}