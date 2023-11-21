// Kullanıcıdan isim alınız
// Kullanıcının girdiği isim XYZ ise istediğiniz yere giriş yaptırınız.
// Değilse, davetli değilsin diyiniz.

//Console.WriteLine("Giriş yapmak istediğiniz ismi giriniz");
//string isim = Console.ReadLine().ToUpper();

//if (isim == "XYZ")
//{
//    Console.WriteLine("Hoşgeldiniz");
//}
//else
//{
//    Console.WriteLine("Davetli Değilsiniz!");
//}

//Console.WriteLine("-----------------------------------------");

//Kullanıcıdan kayıt oluşturmak için bir isim girmesini isteyiniz.

// Ardından giriş yapmak için yeni bir isim isteyiniz.

// 2 girdi eşleşiyorsa, girişe isin veriniz.


Console.WriteLine("Kayıt olmak istediğiniz ismi giriniz.");
string kayitIsmi = Console.ReadLine();
Console.WriteLine("Kayıt oluşturuldu.");

Console.WriteLine("Giriş yapmak istediğiniz ismi giriniz.");
string girisIsmi = Console.ReadLine();

if (kayitIsmi == girisIsmi)
{
    Console.WriteLine("hg");
}
else
{
    Console.WriteLine("gg");
}