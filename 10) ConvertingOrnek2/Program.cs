// Bir öğrenciden ad - soyad - vizeNotu - finalNotu bilgilerini isteyiniz. (Notlar -> Double)
// Ardından Vize'nin 40%'ı
// Final'in 60%'ı etki edecek şekilde bir not ortalaması hesaplayınız
// bunu "........ isimli kişi için ders ortalaması ........ şeklinde 3 farklı Console.WriteLine yöntemi ile yazdırınız.

Console.WriteLine("Adınızı giriniz. ");
string ad = Console.ReadLine();

Console.WriteLine("Soyadınızı giriniz. ");
string soyad = Console.ReadLine();

Console.WriteLine("Vize notunuzu giriniz. ");
double Vize = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Final notunuzu giriniz. ");
double final = Convert.ToDouble(Console.ReadLine());

double ortalama = Vize * 0.4 + final * 0.6;
Console.WriteLine(ad + " " + soyad + " isimli kişi için not ortalaması : " + ortalama);

Console.WriteLine("{0} {1} isimli kişi için not ortalaması : {2}",ad,soyad,ortalama);

Console.WriteLine($"{ad} {soyad} isimli kişi için not ortalaması : {ortalama}");