
/*

1- Aşağıdaki şekli console ekranına çiziniz.

*
**
***
****
*****
******

2- Kullanıcının istediği uzunlukta bir dik üçgen çiziniz.



*/

string mesaj = "*";

for (int i = 0; i < 6;  i++)
{
    Console.WriteLine(mesaj);
    mesaj = mesaj + "*";
}

Console.WriteLine("------------------------------------------");

Console.WriteLine("Dik üçgen kaç birim uzunluğunda olsun ?");
int uzunluk = Convert.ToInt32(Console.ReadLine());

string message = "*";

for(int i = 0; i < uzunluk; i++)
{
    Console.WriteLine(message);
    message = message + "*";
}