
// Показать вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int second = 0;

if (N > 99 && N < 1000 || N < -99 && N > -1000)
{
    if (N > 0) second = N / 10; second = second % 10;
    if (N < 0) second = (-1)*N / 10; second = second % 10;
    Console.Write("Вторая цифра: ");
    Console.Write(second);
}
else Console.Write("Вы что, шутите там? ;D");