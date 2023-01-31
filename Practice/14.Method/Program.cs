
// Найти наибольшее значение 9 значений "стихийным подходом"
/*
int a1 = 23;
int b1 = 1;
int c1 = 9;
int a2 = 231;
int b2 = 233;
int c2 = 43;
int a3 = 8;
int b3 = 874;
int c3 = 1000;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.Write("Наибольшее значение:");
Console.Write(max);
*/


// Найти наибольшее значение 9 значений "методом" или "через функцию"

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 1;
int c1 = 90000;

int a2 = 231;
int b2 = 233;
int c2 = 43;

int a3 = 8;
int b3 = 874;
int c3 = 1000;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.Write("Наибольшее значение: ");
Console.WriteLine(max);
