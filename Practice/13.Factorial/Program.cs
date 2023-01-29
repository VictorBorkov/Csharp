
// Посчитать факториал числа

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int F = 1;
int i = 1;

if (N >= 0)
{
    while (i <= N)
    {
        F = F * i;
        i++;   
    }
    Console.Write("Факториал будет: ");
    Console.Write(F);
}
else
{
    Console.Write("Для этого значения факториал не может быть посчитан");
}

