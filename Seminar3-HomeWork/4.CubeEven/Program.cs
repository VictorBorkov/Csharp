
// Показать кубы чисел, заканчивающихся на четную цифру (все числа от 1 до N)

Console.Write("Задайте любое положительное значение, до которого будут считаться кубы чисел: ");
int end = Convert.ToInt32(Console.ReadLine());
int count = 1;
int C = 1;
int LD = 1;

while (count < end)
{
    C = count * count * count;
    LD = C % 10;
    if (LD % 2 == 0) Console.Write(C + " ");
    count++;
}
