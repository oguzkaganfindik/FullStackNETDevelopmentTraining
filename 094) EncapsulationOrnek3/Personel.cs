namespace _094__EncapsulationOrnek3
{
    internal class Personel
    {
        public Personel()
        {
            KayitTarihi = DateTime.Now;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime KayitTarihi { get; set; }

        int _yas;
        public int Yas
        {
            get
            {
                return _yas;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("18'den küçükler çalışamaz.");
                    _yas = -1;
                }
                else
                {
                    _yas = value;
                }
            }

        }

    }
}
