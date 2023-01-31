
// Найти третью цифру числа или сообщить, что её нет

int N = new Random().Next(-1000000000, 1000000001);
Console.Write("Сгенерировано число: ");
Console.WriteLine(N);

if (N < -99 || N > 99)
{
    while (N < -999 || N > 999)
    {
        N = N / 10;
    }
    N = N % 10;
    if (N < 0) N = -1 * N;
    Console.Write("Третья цифра: ");
    Console.WriteLine(N);
}
else Console.Write("Третьей цифры нет в этом числе!");