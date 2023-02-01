
// Программа проверяет пятизначное число на палиндром

Console.WriteLine("Введите пятизначное число: ");
int P = Convert.ToInt32(Console.ReadLine());

int first = 0; int second = 0; int fourth = 0; int fifth = 0;

fifth = P % 10;
fourth = P / 10 % 10;
second = P / 1000 % 10;
first = P / 10000;

if (first == fifth && second == fourth) Console.WriteLine("Да, это палиндром");
else Console.WriteLine("Ну нет");