namespace _106__PolymorphismOrnek.Models
{
    internal class BaseGeometrikSekil
    {
        public double Yukseklik { get; set; }
        public double Genislik { get; set; }

        // VIRTUAL UNUTMA !
        public virtual void AlanHesapla()
        {
            double alan = Genislik * Yukseklik;
            Console.WriteLine("Şeklin alanı -> " + alan);
        }
    }
}
