// SayilariTopla isminde, 2 sayıyı parametre olarak alıp toplamlarını geriye dönen bir metot.

int SayilariTopla(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    Console.WriteLine("Toplam ---> " + toplam);
    return toplam;
    // toplam değişkeninin değerini dışarıya gönderiyorum.
}

// SayilariTopla int tipinde 2 parametre alıp geriye int değer dönen bir metot.

Console.WriteLine(SayilariTopla(3, 5));

int yeniDegisken = SayilariTopla(3, 5);
Console.WriteLine(yeniDegisken);

// return ifadesi ile dön. bir değer başka bir değişkene aktarılabilir.

// Bu metot artık 2 sayıyı toplayıp bunların sonucunu GERİYE DÖNÜYOR.
// Bu nedenle geriye dönülen değer bir değişkene aktarılabilir veya başka bir noktada kullanılabilir.

// return ifadesi döndüğümüz değerin tipi, metodumunuz tipini belirler.