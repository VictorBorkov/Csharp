// Задача на собаку и двух друзей по имеющейся блок-схеме
int S = 10000;
int F1 = 1;
int F2 = 2;
int D = 5;
int dir = 2;
int count = 0;
int t = 0;

while (S > 10)
{
    if (dir == 1)
    {
        t = S / (F1 + D);
        dir = 2;
    }
    
    else 
    {
        t = S / (F2 + D);
        dir = 1;
    }
    
    S = S - ((F1 + F2) * t);
    count = count + 1;    
}
Console.Write("Собака пробежит столько раз: ");
Console.WriteLine(count);