
// Подсчитать сумму цифр в числе

Console.Write("Введите любое целое число: ");
int Num = Convert.ToInt32(Console.ReadLine()!);
int Sum = 0;
int Step = 0;

while (Num != 0)
{
    Step = Num % 10;
    Num = Num / 10;
    Sum = Sum + Step;

}

if (Sum > 0) Console.Write($"Сумма цифр: {Sum}");
if (Sum < 0) Console.Write($"Сумма цифр: {-Sum}");

