// Создаём треугольник точками на консоли, через цикл
Console.Clear();
int x1 = 1, y1 = 30, x2 = 70, y2 = 1, x3 = 140, y3 = 30;
Console.SetCursorPosition(x1, y1);
Console.WriteLine("o");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("o");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("o");
int x = x1, y = y1;
int count = 0;

while (count < 10000)
{
    int R = new Random().Next(0, 3);
    if (R == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    
    if (R == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }

    if (R == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("o");
    count++;
}
