using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort primeCounter = 0;
            for (ulong i = 2; ; i++)
            {
                if (IsPrime(i))
                {
                    primeCounter++;
                    if (primeCounter == 10001)
                    {
                        Console.WriteLine($"The 10 001st prime is: {i}");
                        break;
                    }
                }
            }
        }

        static bool IsPrime(ulong inputNumber)
        {
            bool isPrime = true;
            for (ulong i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
