//адача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]




Console.Clear();
Console.Write("[");
void Massiv()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]},");
   }
Console.WriteLine("]");
}
Massiv();
Console.WriteLine();



void FillArray(int[] collection)
{
 int length = collection.Length;
 int index = 0;
 while (index < length)

 {
    collection[index] = new Random().Next(0, 2);
    index++;
 }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[ ");
    while (position < count)
{
    Console.Write($"{col[position]}, ");
    position++;
}
Console.Write("]");
Console.WriteLine();

}

int [] array = new int [8]; // new int[число]; создать массив с определённым кол-ом чисел.изначально будет заполнен нулями

FillArray(array);
PrintArray(array);



   
