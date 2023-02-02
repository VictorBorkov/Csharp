
// Найти кубы чисел от 1 до N

Console.Write("Введите любое значение, до которого будем считать кубы чисел: ");
int end = Convert.ToInt32(Console.ReadLine());

if (end > 1)
{
    Console.Write("Кубы чисел:");
    int C = 0;
    int p = 1;
    
    while (p <= end)
    {
        C = p * p * p;
        Console.Write($" {C}");
        p++;
    }
}
else Console.WriteLine("Такое значение не допустимо!");
