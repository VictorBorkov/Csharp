
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int R = new Random().Next(10, 100);
Console.Write("Сгенерированное случайное число: ");
Console.WriteLine(R);

int first = R / 10;
int second = R % 10;
int max = 0;

if (first > second) max = first;
if (second >= first) max = second;

Console.Write("Наибольшая цифра этого числа: ");
Console.Write(max);
