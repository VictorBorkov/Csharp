
// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Задайте любое целое число: ");
int C = Convert.ToInt32(Console.ReadLine());
int LD = 0;

LD = C % 10;

if (C == 0) Console.Write("Ноль не пойдёт ;D");
else if (LD % 2 == 0) Console.Write("Куб вашего числа равен: " + C * C * C);
else Console.Write("Ваше число заканчивается на нечётную цифру.");

