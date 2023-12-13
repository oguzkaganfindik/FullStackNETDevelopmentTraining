namespace _097__InheritanceOrnek1.Models
{
    internal class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void BilgileriYazdir()
        {
            AdSoyadYazdir();
            Console.WriteLine("Maaş ---> " + Maas);
        }
    }
}
