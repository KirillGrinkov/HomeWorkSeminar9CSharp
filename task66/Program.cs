// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine() ?? "");

PrintResult(m, n);

void PrintResult(int m, int n)
{
    Console.Write(SumNumbers(m - 1, n));
}

int SumNumbers(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
        m++;res = m + SumNumbers(m, n);
        return res;
}