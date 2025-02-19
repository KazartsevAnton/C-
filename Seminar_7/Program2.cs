﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100,100) / 10;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i,j] + " "); 
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[5, 5];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if ( n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}