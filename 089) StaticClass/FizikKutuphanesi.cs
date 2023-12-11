namespace _089__StaticClass
{
    internal static class FizikKutuphanesi
    {
        // 3 farklı şekilde sabit değer tutabiliriz.

        public static decimal YerCekimiKuvveti
        {
            get
            {
                return 9.8M;
            }

        } // set kısmını sildiğim için, üzerine atama yapılamaz.

        public const int kaldirmaKuvveti = 12; // const içerisinde staticlik vardir, ayrıca yazılmaz.

        public static readonly int indirmeKuvveti = 2; // böyle bir kuvvet yok.

        // readonly de yalnızca okunabilirlik verir. DEĞER ATAMASI YAPILABİLİR SADECE VE SADECE CONSTRUCTOR'DA!

        // Static bir class içerisinde constructor kodları çalışmayacağından, readonly sabitlik olarak kullanılabiliyor.

    }
}
