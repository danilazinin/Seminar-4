//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int number1 = Math.Abs(num);

int FacterialNum(int kol)
{
    int i = 1;
    int facte = 1;
    while (i <= kol)
    {
        facte = i * facte;
        i ++;

    }
    return facte;
    
}
Console.WriteLine($"{num} -> {FacterialNum(number1)}");

