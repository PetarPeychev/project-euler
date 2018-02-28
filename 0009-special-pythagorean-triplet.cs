using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int tripletSum = int.Parse(Console.ReadLine());
            for (int c = tripletSum; c > 0; c--)
            {
                for (int b = c; b > 0; b--)
                {
                    for (int a = b; a > 0; a--)
                    {
                        if (a * a + b * b == c * c && a + b + c == tripletSum)
                        {
                            Console.WriteLine($"{a}^2 + {b}^2 = {c}^2 and {a} + {b} + {c} = {tripletSum} Product: {a * b * c}");
                        }
                    }
                }
            }
        }
    }
}
