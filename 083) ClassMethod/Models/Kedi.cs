namespace _083__ClassMethod.Models
{
    internal class Kedi
    {
        public string Ad { get; set; }
        public string SevdigiYemek { get; set; }

        public void Mirla()
        {
            Console.WriteLine(Ad + ": Mırrrrrr");
        }

        public void KendiniTanit()
        {
            Console.WriteLine("Miyavv Benim Adım " + Ad);
        }

        public void YemekYe()
        {
            Console.WriteLine(Ad + " " + SevdigiYemek + " yiyor.");
        }

        public void Uyu()
        {
            Console.WriteLine(Ad + "'ın çok uykusu gelmiş, yalana yalana uyuyor.");
        }
    }


}
