/*
Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine());

string AddN(int N)
{
    if (N == 1)
        return N.ToString();
    else
    {
        return N + " " + AddN(N - 1);
    }
}

Console.WriteLine(AddN(N));
