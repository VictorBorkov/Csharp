
// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпослдений и т.д.

void Fill(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        AnyArr[i] = new Random().Next(0, 20);
    }
}

void Show(int[] AnyArr)
{
    Console.Write("Массив данных: ");
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($"{AnyArr[i]} | ");
    }
    Console.WriteLine();
}

void MulPair(int[] AnyArr)
{
    int Mul = 0;
    int j = AnyArr.Length - 1;
    Console.Write("Произведения пар: ");
    for (int i = 0; i < (AnyArr.Length/2); i++)
    {
        Mul = AnyArr[i] * AnyArr[j];
        Console.Write($"{Mul} ");
        j--;
    }
}

int[] Arr = new int[9];
Fill(Arr);
Show(Arr);
MulPair(Arr);