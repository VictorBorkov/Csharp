
// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int three = 0;

if (N > 99 && N < 1000 || N < -99 && N > -1000)

{
    if (N > 0) three = N % 10;
    if (N < 0) three = (-1)*N % 10;

    Console.Write("Последняя цифра: ");
    Console.Write(three);
}

else Console.Write("Вы что, шутите там? ;D");

