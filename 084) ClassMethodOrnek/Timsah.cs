namespace _084__ClassMethodOrnek
{
    internal class Timsah
    {
        public Timsah(string isim, string sevdigiYemek)
        {
            Ad = isim;
            SevdigiYemek = sevdigiYemek;

            Console.WriteLine("Timsahınız " + Ad + " ismi ile oluşturuldu.");
            Console.WriteLine("Sevdiği yemek olarak -> " + SevdigiYemek + " not edildi.");
        }

        public string Ad { get; set; }
        public string SevdigiYemek { get; set; }
        public void Beslen(string yemek)
        {
            if(yemek == SevdigiYemek)
                Console.WriteLine("Ben bunu severim nam nam");
            else
                Console.WriteLine("Ben bunu sevmem. Bana " + SevdigiYemek + " getir.");
        }
    }
}
