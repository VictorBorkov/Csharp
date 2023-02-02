
// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Напишите число, до которого будем выполнять произведенеие: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    int count = 1;
    int M = 1;
    
    while (count <= N)
    {
        M = M * count;
        count++;
    }
    Console.Write($"Произведение всех чисел от 1 до {N} равно {M}");
}
else Console.WriteLine("Такое значение не допустимо!");