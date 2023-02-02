
// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == 0 || B == 0) Console.WriteLine("Такие значения не допустимы");
else if (B == A * A) Console.WriteLine($"Число {B} является квадратом числа {A}");
else if (A == B * B) Console.WriteLine($"Число {A} является квадратом числа {B}");
else Console.WriteLine("Нет, не является");
