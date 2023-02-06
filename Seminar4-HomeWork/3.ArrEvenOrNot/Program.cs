
// Задать массив, заполнить его случайными положительными трехзначными числами. Показать количество чётных и нечётных чисел

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()!);
int even = 0;
int not = 0;

void Fill(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        AnyArr[i] = new Random().Next(100, 1000);
    }
}

void Show(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]} | ");
    }
    Console.WriteLine();
}

void Count(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        if (AnyArr[i] % 2 == 0) even++;
    }
    not = size - even;

}

if (size > 1)
{
    int[] Arr = new int[size];
    Fill(Arr);
    Show(Arr);
    Count(Arr);
    Console.Write($"Количество чётных чисел: {even}. ");
    Console.Write($"Количество нечётных чисел: {not}.");
}
else Console.Write("Задайте значение не меньше 2");