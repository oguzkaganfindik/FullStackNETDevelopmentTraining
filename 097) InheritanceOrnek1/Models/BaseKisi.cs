namespace _097__InheritanceOrnek1.Models
{
    internal class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine("Ad ---> " + Ad);
            Console.WriteLine("Soyad ---> " + Soyad);
        }
    }
}
