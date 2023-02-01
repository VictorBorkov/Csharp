
// Определить номер четверти плоскости, в которой находится точка с координатами Х и Y, причем они не могут быть равны 0

Console.Write("Введите координату Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("Вы попали в первую четверть");
if (X > 0 && Y < 0) Console.WriteLine("Вы попали в четвертую четверть");
if (X < 0 && Y > 0) Console.WriteLine("Вы попали во вторую четверть");
if (X < 0 && Y < 0) Console.WriteLine("Вы попали в третью четверть");