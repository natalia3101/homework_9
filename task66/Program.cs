/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Enter the beginning of range");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the end of range");
int N = int.Parse(Console.ReadLine());

int Range(int M, int N)
{
    if (M == N) return N;
    else return N + Range(M, N - 1);
}


Console.Write(Range(M, N));