using _082__AccessModifiers;
class Program
{
    static void Main(String[] args)
    {
        // Bir proje başka bir projedeki yapıyı kullanacaksa, diğer projeyi reference olarak almalı.

        // Bunun için ikinci projeye sağ tıklayıp -> add -> project reference kısmından yapıya ulaşmak istediğiniz projeyi ekleyiniz.


        // Sample'ın bu projede tanınması için tanımlandığı alanın public olması gerekir. Çünkü ancak public yapılan her projeden erişilebilir.

        //Sample x = new Sample();

        //x.PublicProperty = 1;

        // Public dışındaki bir property başka projede tanınmayacağından, InternalProperty ve PrivateProperty özelliklerine burada ulaşamam.
    }
}