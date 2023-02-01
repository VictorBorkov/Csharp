
// Найти в одномерном массиве число, которое задаёт пользователь

int[] array = {2, 40, 5, 345, 23, -9, 23};
int F = 23;
int i = 0;

while (i < array.Length)
{
    if (array[i] == F)
    {
        Console.Write("Индекс: ");
        Console.WriteLine(i);
        break;
    }
    i++;
}


