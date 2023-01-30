
// Найти максимальное из трех чисел

Console.Write("Укажите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;

if (B > max) max = B;
if (C > max) max = C;

Console.Write("Максимальное значение: ");
Console.Write(max);