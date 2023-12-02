// While ile 100 ile 250 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int ciftlerToplami = 0;
int teklerToplami = 0;

int i = 100;

while (i <= 250)
{
    if (i % 2 == 0)
        ciftlerToplami += i;
    else
        teklerToplami += i;
    i++;
}
Console.WriteLine("Teklerin Toplamı -> " + teklerToplami);
Console.WriteLine("Çiftlerin Toplamı ->" + ciftlerToplami);