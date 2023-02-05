
// Задать массив из 8 элементов, заполненных нулями и единицами, вывести их на экран

int[] Arr = {0, 1, 0, 0, 1, 0, 1, 1};

void Show(int[] AnyArr)
{
    for (int i = 0; i < AnyArr.Length; i++)
    {
        Console.Write($" {AnyArr[i]} ");
    }
    
}

Console.Write("Вот он этот массив: ");
Show(Arr);