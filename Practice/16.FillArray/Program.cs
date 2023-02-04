// Заполнить одномерный массив случайными числами


void F(int[] collection)    // метод заполнения массива
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void P(int[] col)    // метод вывода его на экран
{
    int count = col.Length;
    int position = 0;
    
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }  
}

int Iof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

F(array);  
P(array);
Console.WriteLine();

int pos = Iof(array, 4);
Console.WriteLine(pos);
