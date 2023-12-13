namespace _103__InheritanceOrnek2.NewFolder
{
    internal class Insan : BaseCanli // Ad prop ve Konus metot buraya aktarıldı.
    {
        public string Soyad { get; set; }
        public int ElSayisi { get; set; }
        public int AyakSayisi { get; set; }

        public void BilgiVer()
        {
            Console.WriteLine("El sayısı --> " + ElSayisi);
            Console.WriteLine("Ayak sayısı --> " + AyakSayisi);
        }
    }
}
