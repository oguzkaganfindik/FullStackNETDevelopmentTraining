using _108__AbstractionOrnek1.Abstract;

namespace _108__AbstractionOrnek1.Concrete
{
    internal class Kanepe : BaseMobilya
    {
        public Kanepe()
        {
            Console.WriteLine("KANEPE CONSTRUCTOR TETİKLENDİ");
        }
        public string Kumas { get; set; }

        public override void BilgileriGoster()
        {
            Console.WriteLine(Renk);
            Console.WriteLine(Kumas);
            Console.WriteLine(Fiyat);
        }
    }
}
