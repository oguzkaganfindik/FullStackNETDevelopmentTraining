namespace _105__Polymorphism.Models
{
    internal class BaseCanli
    {
        // Virtual keywordü ile bu metodu miras verilen sınıflarda ezilebilir(override edilebilir) hale getiriyorum.
        public virtual void NefesAl()
        {
            Console.WriteLine("Akciğer solunumu yapıyorum!");
        }
    }
}
