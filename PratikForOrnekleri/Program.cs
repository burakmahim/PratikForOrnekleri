Console.WriteLine("Konsol ekranına 10 kere Kendime inanıyorum, ben bu yazılım işini hallederim! yazdırınız.");

// 10 defa Console.WriteLine dödüren for döngüsü
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine();
Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

//her dönüşünde i'yi bir arttıran ve her seferinde consola yazan for döngüsü
for (int i = 1; i < 20; i++)
{
    Console.Write($"{i}  ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

// her dönüşünde i'yi 2 arttıran ve her seferinde ekrana yazan for döngüsü
for (int j = 2; j < 20; j += 2)
{
    Console.Write($"{j}  ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

// k her seferinde dönerken o anki değerini sum değişkenine ekliyor böylece sum değişkeni for döngüsü bitince sum toplam değer oluyor
int sum = 0;
for (int k = 0; k < 150; k++)
{
    sum += k;
}
Console.WriteLine($"{sum}");
Console.WriteLine();
Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");


// k her seferinde dönerken o anki değer çiftse sumCift'e tekse sumTek'e değişkenine ekliyor.
// böylecefor döngüsü  bitince sumCift cift sayıların sumTek tek sayıların toplam değeri oluyor
int sumCift = 0;
int sumTek = 0;

for (int i = 0; i < 120; i++)
{
    if (i % 2 == 0)
    {
        sumCift += i; //çift sayıların toplamı
    }

    else
    {
        sumTek += i; // tek sayıların yoplamı
    }
}

Console.WriteLine($"çift değerler toplamı {sumCift}");
Console.WriteLine($"tek değerler toplamı {sumTek}");
