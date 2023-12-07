namespace _083__ClassMethod.Models
{
    internal class Kopek
    {
        public string Ad { get; set; }
        public string SevdigiYemek { get; set; }
        public void KendiniTanit()
        {
            Console.WriteLine("Hav hav benim adım " + Ad);
        }

        public void YemekYe()
        {
            Console.WriteLine(Ad + " " + SevdigiYemek + "yiyor.");
        }
    }
}
