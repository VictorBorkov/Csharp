
// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое значение: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе значение: ");
int B = Convert.ToInt32(Console.ReadLine()!);

if (B == A * A) Console.WriteLine("Да, является");
else Console.WriteLine("Нет, не является");