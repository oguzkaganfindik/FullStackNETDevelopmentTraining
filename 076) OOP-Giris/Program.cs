using _076__OOP_Giris;


// Object Oriented Programming -> OOP  ( Nesne Yönelimli Programlama )

// Her işlevin nesneler olarak soyutlandığı bir programlama yaklaşımıdır.

// Bu yaklaşımın temel amacı, ihtiyaç duyulan programı daha küçük parçalara bölerek; yönetilebilir, geliştirilebilir ve yeniden kullanılabilir hale getirmek.


// new'lemek ->> instance almak --> nesne oluşturmak
Insan insan1 = new Insan();  //1. Yöntem

insan1.Isim = "Mahmut";
insan1.Soyisim = "Korhan";
insan1.Yas = 25;
insan1.CocukSayisi = 6;
insan1.DogumTarihi = new DateTime(1998, 02, 05);
insan1.HayattaMi = true;
insan1.EvliMi = false;
insan1.SigaraKullaniyorMu = false;

// Atama durumlarında propertylerin SET metotları tetiklenir.
// Okuma durumlarında propertylerin GET metotları tetiklenir.

Console.WriteLine("1. İnsanın adı -> " + insan1.Isim);

Insan insan2 = new Insan()   //2. Yöntem
{
    Isim = "Ajda",
    Soyisim = "Pekkan",
    Yas = 71,
    CocukSayisi = 0,
    DogumTarihi = new DateTime(1952, 01, 01),
    HayattaMi = true,
    EvliMi = false,
    SigaraKullaniyorMu = false
};

Insan insanTest = new Insan();
Console.WriteLine(insanTest.DogumTarihi); // Default değerleri böyle kontrol edebiliriz.
Console.WriteLine(insanTest.Isim);
Console.WriteLine(insanTest.Yas);
Console.WriteLine(insanTest.HayattaMi);


