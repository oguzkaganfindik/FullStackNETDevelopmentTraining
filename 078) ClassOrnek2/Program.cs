using _078__ClassOrnek2;

// Bir sinema salonu için uygulama.

// Film nesnelerimiz var ---> Movie

// Movie -> Name, Director, TicketPrice, IsDiscountRate

// 2 tane film nesnesi üretelim. Bir tanesi indirimde, diğeri değil.

// Ardından ekrana 2 film için de ----> " Bilet ücretiniz ....." şeklinde yazdıralım.


Movie m1 = new Movie()
{
    Name = "Fight Club",
    Director = "David Fincher",
    TicketPrice = 200,
    IsDiscounted = false,
    DiscountRate = 15,
};

Movie m2 = new Movie //Buradaki parantezler yeni sürümlerde artık zorunlu değil.
{
    Name = "Gora",
    Director = "Cem Yılmaz",
    TicketPrice = 200,
    IsDiscounted= true,
    DiscountRate = 22,
};

if (m1.IsDiscounted)
{
    decimal indirimliFiyat = m1.TicketPrice - (m1.TicketPrice * m1.DiscountRate / 100);
    Console.WriteLine(m1.Name + " filmi için bilet fiyatınız -> " + indirimliFiyat);
}
else
{
    Console.WriteLine(m1.Name + " filmi için bilet fiyatınız -> " + m1.TicketPrice);
}

if (m2.IsDiscounted)
{
    decimal indirimliFiyat = m2.TicketPrice - (m2.TicketPrice * m2.DiscountRate / 100);
    Console.WriteLine(m2.Name + " filmi için bilet fiyatınız -> " + indirimliFiyat);
}
else
{
    Console.WriteLine(m2.Name + " filmi için bilet fiyatınız -> " + m2.TicketPrice);
}