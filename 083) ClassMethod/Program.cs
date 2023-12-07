
// Class Method

// Ad ve Sevdiği Yemek özellikleri olan Kedi ve Köpek classlarını tanımlayalım.

using _083__ClassMethod.Models;

Kopek kopek1 = new Kopek()
{
    Ad = "Taci",
    SevdigiYemek = "Kuzu etli yaş mama"
};

Kopek kopek2 = new Kopek()
{
    Ad = "Karabaş",
    SevdigiYemek = "Tavuk"
};

kopek1.KendiniTanit();
kopek2.KendiniTanit();

kopek1.YemekYe();
kopek2.YemekYe();

// Kedi için metotlar yazalım.

// Mırla ( .... : Mırrrrrr)
// Kendini Tanıt (miyavlayarak adını söylesin)
// YemekYe (........... yiyor.)
// Uyu (.....'nın çok uykusu gelmiş, yalana yalana uyuyor.)

Kedi kedi = new Kedi()
{
    Ad = "Garfield",
    SevdigiYemek = "Lazanya"
};

kedi.Mirla();
kedi.KendiniTanit();
kedi.YemekYe();
kedi.Uyu();