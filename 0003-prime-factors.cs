using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get integer from console, loop through all prime factors in ascending order
            ulong integer = ulong.Parse(Console.ReadLine());
            for (ulong factor = 2; integer > 1; factor++)
                if (integer % factor == 0)
                {
                    while (integer % factor == 0)
                    {
                        integer /= factor;
                        Console.WriteLine(factor);
                    }
                }
        }
    }
}
