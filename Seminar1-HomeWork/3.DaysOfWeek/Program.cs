
// По заданному номеру дня недели вывести его название

Console.Write("Напишите любой номер дня недели: ");
int W = Convert.ToInt32(Console.ReadLine()!);

if (W >= 1 && W <= 7)
{
    if (W == 1) Console.WriteLine("ПН");
    if (W == 2) Console.WriteLine("ВТ");
    if (W == 3) Console.WriteLine("СР");
    if (W == 4) Console.WriteLine("ЧТ");
    if (W == 5) Console.WriteLine("ПТ");
    if (W == 6) Console.WriteLine("СБ");
    if (W == 7) Console.WriteLine("ВС");
}
else Console.WriteLine("Такого дня недели не существует");