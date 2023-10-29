using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbers(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {sum}");
    }

    static int SumNaturalNumbers(int M, int N)
    {
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            if (i > 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
