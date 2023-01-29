// Код для поиска самой тяжелой гири (5 гирь) и это поиск через условия

Console.WriteLine("Напишите вес случайных 5 гирь:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);
int e = int.Parse(Console.ReadLine()!);
int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("А это вес самой тяжелой гири: ");
Console.Write(max);
