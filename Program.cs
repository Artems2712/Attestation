using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 1)
        {
            Console.WriteLine("Натуральные числа в промежутке от N до 1: ");
        }
        else
        {
            Console.WriteLine("Натуральные числа в промежутке от N до 1: ");
            PrintNaturalNumbers(N);
        }
    }

    static void PrintNaturalNumbers(int N)
    {
        if (N >= 1)
        {
            Console.Write(N + " ");
            PrintNaturalNumbers(N - 1);
        }
    }
}
