// Kullanıcıdan kullanıcının istediği sayıda kişi ismi alarak bunları başlarına sayı ekleyerek ekrana yazdırınız.

// 1- Ajda
// 2- Hande
// 3- Tarkan

Console.WriteLine("Girmek istediğiniz isim sayısı:");
int tekrarSayisi = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= tekrarSayisi; i++)
{
    Console.WriteLine("İsimleri giriniz:");
    string isim = Console.ReadLine();
    Console.WriteLine(i + " - " + isim);
}