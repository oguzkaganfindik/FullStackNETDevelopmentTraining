
// Ankara - İstanbul - İzmir şehir isimlerini tutacak bir sehirler listesi oluşturunuz. Ardından foreach ile bütün şehirleri yazdırınız.

List<string> sehirler = new List<string>();

sehirler.Add("Ankara");
sehirler.Add("İzmir");
sehirler.Add("İstanbul");

foreach (var item in sehirler)
{
    Console.WriteLine(item);
}

Console.WriteLine("--- For ile isteseydim ---");
for (int i = 0; i < sehirler.Count; i++)
{
    Console.WriteLine(sehirler[i]);
}


// Kullanıcın girmek istediği 5 tane kahve ismi ile kahveler listesi oluşturunuz. (konsoldan girilecek.) -- Foreach ile yazdırınız.

List<string> kahveler = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Kahve ismi giriniz.");
    string kahve = Console.ReadLine();

    kahveler.Add(kahve);
}

foreach (var kahve in kahveler)
{
    Console.WriteLine(kahve);
}