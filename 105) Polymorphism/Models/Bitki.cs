namespace _105__Polymorphism.Models
{
    internal class Bitki : BaseCanli
    {

        public override void NefesAl()
        {
            // base.NefesAl(); -> ana classtaki çalışan kod şekli.

            Console.WriteLine("Fotosentez yapıyorum.");

        }

        // override + boşluk kullandığımda ezilebilir bütün metotlar gelir. Eğer beklediğim metodu seçeneklerde görmüyorsam virtual tanımlanmamıştır.
    }
}
