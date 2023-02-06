
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10, 99]

void Fill(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        AnyArr[i] = new Random().Next(-500, 500);
    }
}

void Show(int[] AnyArr)
{
    Console.WriteLine("Массив данных:");
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]}|");
    }
    Console.WriteLine();
}

void Scan(int[] AnyArr)
{
    int count = 0;
    for (int i = 0; i < AnyArr.Length; i++)
    {
        if (AnyArr[i] > 9 && AnyArr[i] < 100) count++;
    }
    Console.WriteLine($"Количество элементов получилось: {count}.");
}

int[] Arr = new int[123];
Fill(Arr);
Show(Arr);
Scan(Arr);