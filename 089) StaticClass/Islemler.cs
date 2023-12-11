namespace _089__StaticClass
{
    // Bir class static ise, içerisindeki yapılar da static olmalı.

    // Static keywordü ile tanımlanan bir class NEW'lenemez. Yapılara direkt class ismi ile ulaşılır.
    internal static class Islemler
    {

        public static void Topla(int s1, int s2)
        {
            Console.WriteLine("Toplamları -> " + (s1 + s2));
        }

        public static void Cikar(int s1, int s2)
        {
            Console.WriteLine("Farkları -> " + (s1 - s2));


        }

    }
}
