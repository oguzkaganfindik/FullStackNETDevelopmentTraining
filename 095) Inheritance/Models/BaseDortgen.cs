namespace _095__Inheritance.Models
{
    // Görevi özelliklerini diğer classlara aktarmak olan ( miras vermek olan ) bir class -> Base Class
    internal class BaseDortgen
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public void AlanHesapla()
        {
            double alan = Genislik * Yukseklik;

            Console.WriteLine("BENİM ALANIM ---> " + alan + " birim kare.");
        }
    }
}
