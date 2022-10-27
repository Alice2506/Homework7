// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] numbers = new int[m,n];

void PrintArray(int[,] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}        
PrintArray(numbers);
Console.WriteLine();

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = int.Parse(Console.ReadLine());
    }
}  
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();