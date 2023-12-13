namespace _088__StaticProperty
{
    internal class Araba
    {
        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
        public DateTime UretimTarihi { get; set; }
        public static string Marka { get; set; } // üretilen tüm markaların değeri aynı olacak.
        public string Model { get; set; }
        public string Renk { get; set; }

    }
}
