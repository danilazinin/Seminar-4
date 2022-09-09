Console.Clear();
Console.WriteLine("Введите число:");
int alb = int.Parse(Console.ReadLine());


int SravnenieChisel (int kol)
{
    int count = 10;
    int i = 1;
    while(kol >= count)
    {
        count = count*10;
        i++;
    }
    return i;
}

Console.WriteLine($"{alb} -> {SravnenieChisel(alb)}");