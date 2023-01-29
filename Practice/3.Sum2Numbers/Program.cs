// Задача на сложение 2х чисел

// Самый простой вариант
/*
int A = 10;
int B = A/2;
Console.WriteLine("Ответ:");
Console.WriteLine(A+B);
*/

// Показания вводятся вручную
/*
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(System.Console.ReadLine());
int result = A + B;
Console.Write("Ответ: ");
Console.WriteLine(result);
*/

// Показания рандомные
int A = new Random().Next(-100, 10);
Console.Write("Первое число: ");
Console.WriteLine(A);
int B = new Random().Next(0, 100);
Console.Write("Второе число: ");
Console.WriteLine(B);
int result = A + B;
Console.Write("Ответ: ");
Console.WriteLine(result);

/*
Console.Write("Введите первое число: ");
double A = Console.Read();
Console.Write("Введите второе число: ");
double B = Console.Read();
double result = A + B;
Console.Write("Ответ: ");
Console.WriteLine(result);
*/