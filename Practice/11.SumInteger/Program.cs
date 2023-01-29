
// Найти сумму всех целых значений, которые получаются при делении на 2, в диапазоне от 0 и до какого-то значения

Console.Write("Задайте значение, до которого будем считать: ");
int end = int.Parse(Console.ReadLine()!);
int count = 0;
int sum = 0;

while (count < end)
{
    if (count % 2 == 0) sum = sum + count;
    count++;
}

Console.Write("Сумма целых значений: ");
Console.Write(sum);
