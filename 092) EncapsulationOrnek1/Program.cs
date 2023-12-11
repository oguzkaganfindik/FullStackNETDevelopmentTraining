
// Bir Araba Class
// Marka, Model, Renk, KapiSayisi

// KapiSayisi Property'sine 2 , 4 dışında değer atanamasın. atanmaya çalışılırsa, bir mesaj ile uyarı verilsin ve değer -1 olarak atansın.


using _092__EncapsulationOrnek1;

Araba a1 = new Araba();

a1.Marka = "Mercedes";
a1.Model = "CLE";
a1.Renk = "Gri";
a1.KapiSayisi = 25;

Console.WriteLine(a1.KapiSayisi);

void HazirMi(Araba araba)
{
    if (araba.KapiSayisi == -1)
        Console.WriteLine("KAPI SAYISI ATAMASINDA BİR HATA OLMUŞ, YENİDEN DÜZENLENMEDEN ÜRETİLEMEZ.");
    else
        Console.WriteLine("Hazırız.");
}

HazirMi(a1);