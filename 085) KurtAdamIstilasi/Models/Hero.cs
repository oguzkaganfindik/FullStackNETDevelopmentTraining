namespace _085__KurtAdamIstilasi.Models
{
    internal class Hero
    {

        public string NickName { get; set; }
        public string Race { get; set; }
        public string Branch { get; set; }
        public int Damage { get; set; } // Race ve Branch değerlerine göre hesaplanacak hasar miktarı.
        public void Attack()
        {
            // ırk -> insan +5, orc +10

            // savaşçı -> 20-40
            // büyücü -> 30-35
            // okçu -> 5-55

            Random rnd = new Random();

            Damage = 0; // her saldırıda baştan yeni bir hasar miktarı hesaplamak için 0'lanıyor.

            if (Race == "İnsan")
                Damage += 5;
            else
                Damage += 10;

            switch (Branch)
            {
                case "Savaşçı":
                    Damage += rnd.Next(20, 41);
                    break;
                case "Büyücü":
                    Damage += rnd.Next(30, 36);
                    break;
                case "Okçu":
                    Damage += rnd.Next(5, 56);
                    break;

            }
        }

    }
}
