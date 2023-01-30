

// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Задайте кратное: ");
int K = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте делитель: ");
int D = Convert.ToInt32(Console.ReadLine());
int ost = K % D;

if (ost == 0)
{
    Console.Write("Да, число ");
    Console.Write(K);
    Console.Write(" является кратным числа ");
    Console.WriteLine(D);
}
else
{
    Console.Write("Нет, не кратное, есть остаток ");
    Console.Write(ost);
}