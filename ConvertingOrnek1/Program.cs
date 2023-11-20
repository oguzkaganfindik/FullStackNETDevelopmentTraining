// Sabit bir pi sayısı değişkeni tanımlayın ve değerini 3.14 olarak atayın.
// Kullanıcıdan bir yarıçap uzunluğu alıp (r)
// Dairenin alanını hesaplayarak ekrana yazdırın (pi r kare)

const float pi = 3.14f;

Console.Write("bir yarıçap uzunluğu giriniz: ");
float r = Convert.ToSingle(Console.ReadLine());
Console.Write("Dairenin alanı: " + pi * r * r);