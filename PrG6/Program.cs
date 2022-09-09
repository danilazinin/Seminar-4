Console.WriteLine("Введите число для получения таблицы кубов:");
bool checkNum = int.TryParse(Console.ReadLine(), out int num);

while (!checkNum)
{
    Console.WriteLine("Введите число для проверки:");
    checkNum = int.TryParse(Console.ReadLine(), out num);
}
