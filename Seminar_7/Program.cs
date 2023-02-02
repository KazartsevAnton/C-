// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); i++)
    {
        matrix[i,j] = Math.Round(new Random().NextDouble()*100,2);
        Console.Write($"{matrix[i,j]}  ");
    }
    System.Console.WriteLine();
}