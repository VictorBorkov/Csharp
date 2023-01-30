
// Удалить вторую цифру трёхзначного числа

Console.Write("Задайте трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 0;
int third = 0;
int X = 0;

if (N > 99 && N < 1000 || N < -99 && N > -1000)
{
    third = N % 10;
    second = N / 10; second = second % 10;
    first = N / 100;

    X = first * 10 + third;
    
    Console.Write("Новое число: ");
    Console.Write(X);
}
else Console.Write("Вы что, шутите там? ;D");