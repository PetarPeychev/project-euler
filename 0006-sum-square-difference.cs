using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong sumOfTheSquares = 0;
            ulong sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfTheSquares += (ulong)(i * i);
                sum += (ulong)i;
            }
            ulong squareOfTheSum = (ulong)(sum * sum);
            ulong difference = squareOfTheSum - sumOfTheSquares;
            Console.WriteLine($"Difference between square of the sum and sum of the squares of 1-100: {difference}");
        }
    }
}
