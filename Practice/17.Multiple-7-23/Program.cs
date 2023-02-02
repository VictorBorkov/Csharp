// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Задайте число: ");
int Number = Convert.ToInt32(Console.ReadLine()!);

if (Number % 7 == 0 || Number % 23 == 0)
{
    if (Number % 7 == 0) Console.WriteLine("Да, число " + Number + " является кратным числам 7");
    if (Number % 23 == 0) Console.WriteLine("Да, число " + Number + " является кратным числам 23");
}
else Console.WriteLine("Нет, не кратное");