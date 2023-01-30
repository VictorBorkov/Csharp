
// Показать четные числа от 1 до N

Console.Write("Задайте значение, до которого будем показывать четные числа: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (N > 1)
{
    Console.Write("Чётные числа: ");
    
    while (count <= N)
    {
        Console.Write(count);
        Console.Write(", ");
        count +=2;
    }
    Console.Write("вот и всё!");
}
else Console.Write("Такое значение не допустимо по условию задачи!");

