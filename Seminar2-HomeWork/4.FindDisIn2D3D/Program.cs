
// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Выбирите систему в которой будем работать, напишите 2D или 3D: ");
string D = Console.ReadLine()!;

if (D.ToUpper() == "2D")
{
    Console.WriteLine("Вы выбрали двухмерное пространство!");
    Console.WriteLine("Чтобы найти расстояние между двумя точками, введите координаты точек A(x1;y1) и B(x2;y2):");
    Console.Write("- введите координату x1: ");
    int X1 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату y1: ");
    int Y1 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату x2: ");
    int X2 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату y2: ");
    int Y2 = Convert.ToInt32(Console.ReadLine()!);

    double AB = 0;
    AB = (X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1);
    AB = Math.Sqrt(AB);

    Console.WriteLine($"Расстояние между точками получилось: {AB}");
}

else if (D.ToUpper() == "3D")
{
    Console.WriteLine("Вы выбрали треххмерное пространство!");
    Console.WriteLine("Чтобы найти расстояние между двумя точками, введите координаты точек A(x1;y1;z1) и B(x2;y2;z2):");
    Console.Write("- введите координату x1: ");
    int X1 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату y1: ");
    int Y1 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату z1: ");
    int Z1 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату x2: ");
    int X2 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату y2: ");
    int Y2 = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("- введите координату z2: ");
    int Z2 = Convert.ToInt32(Console.ReadLine()!);

    double AB = 0;
    AB = (X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1);
    AB = Math.Sqrt(AB);

    Console.WriteLine($"Расстояние между точками получилось: {AB}");
}
else
{
    Console.WriteLine("Вы опечатались, введите 2D или 3D");
}





/*
Console.WriteLine("Чтобы найти расстояние между точками в 3D измерении - введите координаты x, y, z. Если нужно 2D, тогда для одной любой координаты введите 0 ");
Console.Write("Введите координату x: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z: ");
int Z = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0 || Z == 0)
{
    Console.WriteLine("Вы выбрали 2D измерение!");

}
*/
