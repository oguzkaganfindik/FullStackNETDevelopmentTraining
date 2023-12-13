namespace _108__AbstractionOrnek1.Abstract
{
    // abstract class çünkü görevi miras vermek.
    // nesne oluşturulmayacak.
    internal abstract class BaseMobilya
    {
        public BaseMobilya()
        {
            Console.WriteLine("BASEMOBILYA CONSTRUCTOR TETİKLENDİ.");
        }
        public string Renk { get; set; }
        public decimal Fiyat { get; set; }

        public abstract void BilgileriGoster();
        // Miras alan class içerisinde gövdesi doldurulsun.

    }
}
