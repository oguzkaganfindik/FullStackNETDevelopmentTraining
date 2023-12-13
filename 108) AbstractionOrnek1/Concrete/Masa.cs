using _108__AbstractionOrnek1.Abstract;

namespace _108__AbstractionOrnek1.Concrete
{
    internal class Masa : BaseMobilya
    {
        public Masa()
        {
            Console.WriteLine("MASA CONSTRUCTOR TETİKLENDİ.");
        }
        public string Malzeme { get; set; }

        public override void BilgileriGoster()
        {
            Console.WriteLine(Renk);
            Console.WriteLine(Malzeme);
            Console.WriteLine(Fiyat);
        }
    }
}
