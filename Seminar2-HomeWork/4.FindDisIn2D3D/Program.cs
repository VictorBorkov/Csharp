
// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Выбирите систему в которой будем работать, напишите 2D или 3D: ");
string D = Console.ReadLine()!;

if (D.ToUpper() == "2D")
{
    Console.WriteLine("Вы выбрали двухмерное пространство!");
    
}
else if (D.ToUpper() == "3D")
{
    Console.WriteLine("Вы выбрали треххмерное пространство!");
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
