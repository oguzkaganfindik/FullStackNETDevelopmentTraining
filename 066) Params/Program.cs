// Sayısız (sayısı belirsiz) parametre göndermek için kullanılır.

decimal FiyatlariHesapla(params decimal[] fiyatlar)
{
    decimal toplamFiyat = 0;

	foreach (var item in fiyatlar)
	{
		toplamFiyat = toplamFiyat + item;
	}

	return toplamFiyat;
}

decimal geriDonen =  FiyatlariHesapla(20, 40, 30.5m, 50.3m, 15, 3, 29, 2); //istediğiniz sayıda decimal parametre gönderebilirsiniz. Bunlar metoda gidip fiyatlar dizisini oluşturacak.

Console.WriteLine("Ürünleriniz için ödemeniz gereken toplam fiyat -> " + geriDonen);