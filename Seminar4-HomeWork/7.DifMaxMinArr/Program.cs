
// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void Fill(double[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        AnyArr[i] = Math.Round(new Random().NextDouble() * new Random().Next(-20, 20), 4);
    }
}

void Show(double[] AnyArr)
{
    Console.WriteLine("Массив данных:");
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]} | ");
    }
    Console.WriteLine();
}

void MaxMin(double[] AnyArr)
{
    double Max = 0;
    double Min = 0;
    for (int i = 0; i < AnyArr.Length; i++)
    {
        if (AnyArr[i] > Max) Max = AnyArr[i];
        if (AnyArr[i] < Min) Min = AnyArr[i];
    }
    Console.WriteLine($"Минимальное значение: {Min}.");
    Console.WriteLine($"Максимальное значение: {Max}.");
    Console.WriteLine($"Дельта равна: {Math.Round(Max-Min, 4)}.");
}

double[] Arr = new double[12];
Fill(Arr);
Show(Arr);
MaxMin(Arr);