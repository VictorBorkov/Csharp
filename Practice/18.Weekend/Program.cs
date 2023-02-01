
// Дано число, обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Напишите любой номер дня недели: ");
int W = int.Parse(Console.ReadLine());

if (W >= 1 && W <= 7)
{
    if (W >= 1 && W <= 5) Console.WriteLine("Нет, это будний день");
    if (W == 6 || W == 7) Console.WriteLine("Да, это выходной");
}
else Console.WriteLine("Такого дня недели не существует");