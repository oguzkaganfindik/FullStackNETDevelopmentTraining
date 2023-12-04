/* 
 RecursiveMethods

 Faktöriyel hesaplayan bir recursive metot yazınız.
 
5! -> 5 x 4!
5! -> 5 x 4 x 3!
5! -> 5 x 4 x 3 x 2!
5! -> 5 x 4 x 3 x 2 x 1!
5! -> 5 x 4 x 3 x 2 x 1
*/

int FaktoriyelHesapla(int sayi)
{
    if (sayi == 1)
        return 1;
    else
        return sayi * FaktoriyelHesapla(sayi - 1);
}

Console.WriteLine(FaktoriyelHesapla(5));

// Recurive şekilde Fibonacci serisi kodunu araştırıp,
// Değerler ile debuglayalım.