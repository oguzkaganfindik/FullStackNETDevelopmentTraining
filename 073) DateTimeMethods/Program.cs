
// DateTime Methods

// -> Zaman ile ilgili metotlar.

// Anlık tarih ve saat bilgisi.
Console.WriteLine(DateTime.Now);

// Anlık tarih
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());

// Anlık saat
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

// Örnek -> İstenilen formatta an bilgisini yazdırınız.
// gün.ay.yıl saat.dk

Console.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

// Gün Ay Yıl bilgilerini ayrı ayrı çekmek

Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);

// Yeni tarih oluşturma
DateTime yeniZaman = new DateTime(1995, 04, 27, 8, 15, 20);

// zaman farkı

TimeSpan zamanFarki = DateTime.Now - yeniZaman;
Console.WriteLine(zamanFarki);
Console.WriteLine(zamanFarki.TotalDays);

