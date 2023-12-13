namespace _099__ClassPropertyTypeOrnek.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Category Category { get; set; }


        public void BilgileriGoster()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(UnitPrice);
            Console.WriteLine(Category.CategoryName);
            Console.WriteLine(Category.CategoryDescription);
        }
    }
}
