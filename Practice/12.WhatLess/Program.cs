
// Найти меньшее число из 4х вводимых

Console.Write("Первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Третье число: ");
int C = int.Parse(Console.ReadLine()!);
Console.Write("Четвертое число: ");
int D = int.Parse(Console.ReadLine()!);
int min = A;

if (B < min) min = B;
if (C < min) min = C;
if (D < min) min = D;

Console.Write("Наименьшее значение: ");
Console.Write(min);
