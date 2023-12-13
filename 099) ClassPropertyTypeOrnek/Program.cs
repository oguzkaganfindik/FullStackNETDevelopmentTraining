
// Product -> Id, ProductName, UnitPrice, CategoryName, CategoryDescription

// CategoryName, CategoryDescription -> Category 

// Örnek bir ürün ve kategori üzerinden test ediniz.

// Ürüne ait bütün bilgileri bir BilgileriGoster() metodu ile getiriniz.

// Paint çizimi de isteniyor.

using _099__ClassPropertyTypeOrnek.Models;

// 1. Örnek
Category cat = new Category()
{
    CategoryName = "Şekerler",
    CategoryDescription = "Abur cubur / tatlı"
};

Product product1 = new Product()
{
    Id = 1,
    Name = "Ekler",
    UnitPrice = 150,
    Category = cat
};

product1.BilgileriGoster();

Console.WriteLine("----------------------");

Product product2 = new Product()
{
    Id = 2,
    Name = "Yumurta",
    UnitPrice = 5,
    Category = new Category
    {
        CategoryName = "Tavuk mamülleri",
        CategoryDescription = "Gıdaklayan tavuk ürünleri"
    }
};
// YUKARIDAKİ ŞEKİLDE DE BİR NESNE ATAMASI YAPILABİLİR.