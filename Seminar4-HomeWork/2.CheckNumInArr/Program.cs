
// Определить, присутсвует ли в заданном массиве, некоторое число

int[] Arr = {10, 0, -63, 16, 5, 2, 7, 23, 50, 99, -41};

void Show(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]} | ");
    }
    Console.WriteLine();
}

Console.Write("Задайте искомое число: ");
int f = Convert.ToInt32(Console.ReadLine()!);


void Find(int[] AnyArr)
{
    int pos = -1;
    for (int i = 0; i < AnyArr.Length; i++)
    {
        if (f == AnyArr[i]) pos = i;
    }
    if (pos > -1) Console.WriteLine($"Ответ: да, есть тут такое число и находится под индексом {pos}.");
    else Console.WriteLine("Ответ: такого числа нет в этом массиве!");
}

Console.WriteLine("Заданный массив:");
Show(Arr);
Console.WriteLine($"Искомое число: {f}");
Find(Arr);
