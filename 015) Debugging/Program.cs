// Debugging

// Yarıçapı verilen bir dairenin alanını yanlış hesaplayan bir uygulama yazınız.

const float pi = 3.14F;
Console.WriteLine("yarıçap giriniz");
float yaricap  = Convert.ToSingle(Console.ReadLine());
float alan = 2 * pi * yaricap; //yanlış hesaplama

Console.WriteLine("Dairenin alanı -> " + alan);

//Debugging -> Bir programı istediğimiz noktada durdurup satır satır incelemeye yarar.

// Bu sayede yapılan işlemlerin sırasını, kullanılan değişkenleri ve değişkenlere atanmış olan değerleri daha net bir şekilde izleyebiliyoruz.