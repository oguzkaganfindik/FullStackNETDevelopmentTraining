namespace Variables_Degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variables - Değişkenler

            //Değişkenle en basit tabiriyle verilerin geçici olarak depolandığı alanlardır.

            //Veriler RAM (Random Access Memory) üzerinde depolanır.

            //C# veri tipi güvenliği olan bir dil olduğu için bir değişken tanımlanırken içerisine hangi tip verilerin tutulacağı belirtilmeli.

            /*
            Değişken Tipleri
            
            -Metinsel-

            * char = '.'
            * string = "...";
            
            -Tam Sayılar-

            * int = 2.1 milyar (+,-)
            * long = 2.1 milyar'dan daha büyük (+,-)
            * short = 32767(-,+)
            * byte = 255 (+,-)
            
            -Ondalık Sayılar- (Genellikle kullanıldığı alanlar)
            *float = 11.4F (Çember - daire işlemleri)
            *double = 11.4 (Diğer geometrik işlemleri)
            *decimal = 11.4M (Parasal işlemler)
            
            -Mantıksal-
            * bool = true / false
            
            isimlendirme : camelCasing

            VeriTipi degiskenAdi = atanacakDeger;

            VeriTipi degiskenAdi;
            degiskenAdi = atanacakDeger; 
             
             */

            char karakterDegiskeni = 'a';

            string metin = "Buraya metin girebilirsiniz.";

            byte sayi1 = 240;
            int sayi2 = 1231231211; //En çok int kullanılacak
            long sayi3 = 1231123112312131233;
            short sayi4 = 14521;

            float ondalikSayi1 = 3.14F;
            double ondalıkSayi2 = 3.14;
            decimal ondalikSayi3 = 3.14M;

            bool silindiMi = true;
            bool yetiskinMi = false;

            //Değişkeni kullanmayacaksan tanımlama.

            //Değişken adında asla boşluk yok!

            //Değişken adı camelCasing yani küçük harfle başlar. Boşluk gerektiğinde harf büyür.

            //Değişken ismi içerisinde veya sonunda rakam olabilir. Fakat asla rakamla başlamaz.
        }
    }
}