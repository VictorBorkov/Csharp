// Задача на особое приветсвие, если это любимчик. Это первая задача на ветвление блок-схемы
Console.Write("Добрый день, введите имя: ");
string user = Console.ReadLine()!;

if (user.ToLower() == "саша")
{
    Console.WriteLine("Йоу, Йоу, Саня, как дела братан?");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(user);
}
