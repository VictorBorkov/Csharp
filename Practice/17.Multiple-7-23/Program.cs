// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Задайте число: ");
int N = int.Parse(Console.ReadLine());

if (N % 7 == 0 && N % 23 == 0)
{
    Console.Write("Да, число ");
    Console.Write(N);
    Console.WriteLine(" является кратным числам 7 и 23");
}
else
{
    Console.WriteLine("Нет, не кратное");
}