// Bir personel kaydı yapmak istiyorum

// Ad - Soyad - Yas - KayitTarihi bilgileri var.

// Personel oluşturulur oluşturulmaz kayıt tarihi o an olarak atanacak.

// Personel yaşına 18'den küçük bir değer atanmak istenirse bir uyarı mesajı yayınlayıp yaş değerine -1 atayınız.

using _094__EncapsulationOrnek3;

Personel p = new Personel() // burada ctor tetiklenir.
{
    Ad = "Serdar",
    Soyad = "Ortaç",
    Yas = 15,
};

Console.WriteLine(p.Yas);