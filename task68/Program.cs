﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine() ?? "");

AkkermanFunction(m,n);

Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");


int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}