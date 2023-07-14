// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Задайте значение N: ");
 int N = int.Parse(Console.ReadLine() ?? "");

NumberInOrder(N);


int NumberInOrder(int N, int M = 0)
{
    if (N == M) 
        return N;
    else Console.Write($"{NumberInOrder(N, M + 1)}, ");
        return M;
 }

