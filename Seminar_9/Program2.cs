//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M: ");
uint m = uint.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
uint n = uint.Parse(Console.ReadLine()!);

uint sum = CalcNaturalNumbersSumRecursively(m, n);

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {sum}");
uint CalcNaturalNumbersSumRecursively(uint m, uint n)
{
	if (m < 1 || n < 1 || m > n)
	{
		return 0;
	}
	if (m == n)
	{
		return m;
	}
	return m + n + CalcNaturalNumbersSumRecursively(m + 1, n - 1);
}
