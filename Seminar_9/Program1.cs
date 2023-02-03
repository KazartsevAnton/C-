//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число N: ");
uint n = uint.Parse(Console.ReadLine()!);

PrintNaturalNumbersRecursively(n);

void PrintNaturalNumbersRecursively(uint n)
{
	Console.Write(n);
	if (n > 1)
	{
		Console.Write(", ");
		PrintNaturalNumbersRecursively(n - 1);
	}
}
