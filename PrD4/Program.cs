Console.Clear();
Console.Write("Введите число: ");
bool res = uint.TryParse(Console.ReadLine(), out uint number);
ulong result;
result = Fact(number);
if (!res)
{
    Console.WriteLine("Что-то пошло не так");
}
else
{
    Console.WriteLine($"{number}->{result}");
}

ulong Fact(uint num) // ulong	0 to 18,446,744,073,709,551,615	Unsigned 64-bit integer	System.UInt64
{
    if (num == 0)
    {
        return 1;
    }
    return num * Fact(num - 1); // 1 * 2 * 3 * ... *(n-1) * n = (n-1)! * n = n!
}
