// Заполнить одномерный массив случайными числами


void F(int[] col)    // метод заполнения массива
{
    int i = 0;

    while (i < col.Length)
    {
        col[i] = new Random().Next(1, 10);
        i++;
    }
}

void P(int[] col2)    // метод вывода его на экран
{
    int i2 = 0;

    while (i2 < col2.Length)
    {
        Console.WriteLine(col2[i2]);
        i2++;
    }
    
}

int[] array = new int[10];

F(array);  
P(array);
