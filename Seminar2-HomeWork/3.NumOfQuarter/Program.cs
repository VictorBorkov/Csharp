
// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти, 1, 2, 3 или 4: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 1) Console.WriteLine("Это первая четверть. Диапазон координат: x - от 0 до бесконечности, y - от 0 до бесконечности");
else if (N == 2) Console.WriteLine("Это вторая четверть. Диапазон координат: x - от минус бесконечности до 0, y - от 0 до бесконечности");
else if (N == 3) Console.WriteLine("Это третья четверть. Диапазон координат: x - от минус бесконечности до 0, y - от минус бесконечности до 0");
else if (N == 4) Console.WriteLine("Это четвертая четверть. Диапазон координат: x - от 0 до бесконечности до 0, y - от минус бесконечности до 0");
else Console.WriteLine("Значение задано не корректно");