
// STATIC PROPERTY

// Bir fabrika yazılımı, araba üreteceğiz.

// Üretim tarihi - Marka - Renk - Model propertyleri olacak.

// ** Bu fabrikada üretilen bütün arabaların markası Mercedes **

using _088__StaticProperty;

Araba.Marka = "Mercedes";

Araba a1 = new Araba()
{
    Model = "2023",
    Renk = "Gece Mavisi"
};

Araba a2 = new Araba()
{
    Model = "2020",
    Renk = "Gri"
};

Console.WriteLine("Bu fabrikadaki arabaların markası ---> " + Araba.Marka);