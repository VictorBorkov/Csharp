
// Найти сумму чисел одномерного массива стоящих на нечётной позиции

void Fill(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        AnyArr[i] = new Random().Next(0, 100);
    }
}

void Show(int[] AnyArr)
{
    Console.WriteLine("Массив данных:");
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]} ");
    }
    Console.WriteLine();
}

void SumOddIndex(int[] AnyArr)
{
    int Sum = 0;
    for (int i = 0; i < AnyArr.Length; i++)
    {
        if (i % 2 != 0) Sum = Sum + AnyArr[i];
    }
    Console.WriteLine($"Сумма чисел стоящих на нечётной позиции равна {Sum}.");
}

int[] Arr = new int[10];
Fill(Arr);
Show(Arr);
SumOddIndex(Arr);
