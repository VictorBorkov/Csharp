
// Найти сумму всех четных чисел от 1 и до какого-то значения

Console.Write("Задайте значение, до которого будем считать: ");
int end = int.Parse(Console.ReadLine()!);
int sum = 0;
int count = 0;

while (count < end)
{
    sum = sum + count;
    count = count + 2;    
}
Console.Write("Сумма получилась: ");
Console.WriteLine(sum);