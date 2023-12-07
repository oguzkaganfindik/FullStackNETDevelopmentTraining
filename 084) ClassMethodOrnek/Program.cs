// Bir Timsah classı oluşturalım. Ad ve Sevdiği yemek özelliklerinden oluşsun. İçerisinde Beslen Metodu var ve bu metot bir parametre alıyor (parametre : timsaha verilen yemek ) yemek sevdiği yemek ile eşleşirse nam nam nam diye yiyor eşleşmezse ise beğenmiyor ve bize bunu bildiriyor.

// Timsahın bilgilerini konsol ekranında alarak oluşturalım.

// Besleme işlemini yine konsol ekranından yapalım.

using _084__ClassMethodOrnek;

Console.WriteLine("Merhabalar, timsahınızı emanet edebileceğiniz en doğru yere geldiniz. Bana lütfen timsahınızın ismini söyleyiniz.");
string isim = Console.ReadLine();

Console.WriteLine(isim + " en çok hangi yemeği yemeyi sever?");
string sevdigiYemek = Console.ReadLine();

Console.WriteLine("Kaydı oluşturuyorum.");

Timsah timsah = new Timsah(isim, sevdigiYemek);

Console.WriteLine("hangi yemeği denemek istiyorsunuz?");
string gonderilecekBesin =  Console.ReadLine(); // iskender

timsah.Beslen(gonderilecekBesin);