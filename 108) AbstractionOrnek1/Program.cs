
// Bir mobilyacı dükkanı

// Masa -> Renk, Malzeme , Fiyat 
// Kanepe -> Renk, Kumaş , Fiyat 

// BilgileriYazdir diye ortak bir metot. (Abstract bir metot)

// Birer masa ve kanepe nesnesi oluşturup metotları çalıştırınız.

// Base class -> BaseMobilya (new'lenemesin.)
// Klasörlerim -> Abstract, Concrete


using _108__AbstractionOrnek1.Concrete;

Masa m = new Masa()
{
    Renk = "Kırmızı",
    Malzeme = "Tahta",
    Fiyat = 200
};

Kanepe k = new Kanepe()
{
    Renk = "Parlement Mavisi",
    Kumas = "Kadife",
    Fiyat = 13000
};

m.BilgileriGoster();
k.BilgileriGoster();


// EK NOT -> BaseMobilya class'ı Abstract olarak tanımlandığı için New'lenemez.

// Abstact bir class bile olsa CONSTRUCTOR'I vardır!

// Peki bu constructor new'lenmeden nasıl çalıştırılabilir ?
// Alt class new'lendiğinde, base class'ın constructorı ilk önce tetiklenir.

//BaseMobilya x = new BaseMobilya();