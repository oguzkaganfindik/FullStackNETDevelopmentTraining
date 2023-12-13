namespace _107__Abstraction.Abstract
{
    // Abstract keywordü ile class'ı yalnızca miras verme görevli tanımlamış oluyorun. Artık New'lenemez, yani NESNE OLUŞTURULAMAZ.

    internal abstract class BaseMuzikAleti
    {

        public string Marka { get; set; }
        public string Aciklama { get; set; }

        public abstract void SesVer();
        // Gövdesini doldurmayacağınız metotları abstract tanımlarsınız.
        // Abstract bir metot, yalnız abstract bir classta tanımlanabilir.


        // Abstract class içerisinde normal metot da yazılabilir.

    }
}
