using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            uint previousTerm = 1;
            uint currentTerm = 2;
            ulong evenSum = 0;
            while (currentTerm < 4000000)
            {
                if (currentTerm % 2 == 0) evenSum += currentTerm;
                uint oldCurrentTerm = currentTerm;
                currentTerm += previousTerm;
                previousTerm = oldCurrentTerm;
            }
            Console.WriteLine(evenSum);
        }
    }
}
