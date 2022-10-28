// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double[,] numbers = new double[m,n];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
    Console.WriteLine();
    }
}

double GetRandomNumber(double min, double max)
{
    return Math.Round(new Random().NextDouble() * (max - min) + min, 1);
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = GetRandomNumber(-10,10);
        }
    }
}

PrintArray(numbers);
FillArray(numbers);
Console.WriteLine();
PrintArray(numbers);