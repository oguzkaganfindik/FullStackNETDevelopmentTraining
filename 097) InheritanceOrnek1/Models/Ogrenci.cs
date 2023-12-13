namespace _097__InheritanceOrnek1.Models
{
    internal class Ogrenci : BaseKisi
    {
        public string OgrenciNo { get; set; }

        public void BilgileriYazdir()
        {
            AdSoyadYazdir();
            Console.WriteLine("Öğrenci No ---> " + OgrenciNo);

        }

    }
}
