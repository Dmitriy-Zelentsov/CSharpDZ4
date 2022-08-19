// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] CreateArray(int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[]array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
           Console.Write (", "); 
        }
        Console.Write($"{array[i]}");
    }
    Console.Write ("]");
}
int [] array = CreateArray(8, 1, 100);
PrintArray(array);