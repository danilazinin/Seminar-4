

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number --;
    }
    return sum;
}
int GetSumNumsMIn(int number)
{
    int sum = 0;
    while(number < 0)
    {
        sum += number;
        number ++;
    }
    return sum;

}
if (num > 0)
{
    Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");
}
else 
{
     Console.WriteLine($"Сумма чисел = {GetSumNumsMIn(num)}");
}
 