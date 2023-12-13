namespace _103__InheritanceOrnek2.NewFolder
{
    internal class Kopek : BaseCanli
    {
        public int PatiSayisi { get; set; }
        public bool KuduzMu { get; set; }

        public void BilgiVer()
        {
            Console.WriteLine("Pati sayısı -> " + PatiSayisi);
            Console.WriteLine(KuduzMu ? "Köpek kuduz!" : "Köpek kuduz değil.");
        }

        public void Havla()
        {
            Console.WriteLine("HavHav");
        }
    }
}
