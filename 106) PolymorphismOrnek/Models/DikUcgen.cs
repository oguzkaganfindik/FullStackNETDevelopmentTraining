namespace _106__PolymorphismOrnek.Models
{
    internal class DikUcgen : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            double alan = Genislik * Yukseklik / 2;
            Console.WriteLine("Alan ---> " + alan);
        }
    }
}
