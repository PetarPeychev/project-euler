using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            long largestProductValue = 0;
            int largestProductStartingIndex = 0;
            for (int i = 0; i < inputNumber.Length - 13; i++)
            {
                long currentProductValue = int.Parse(inputNumber[i].ToString());
                for (int j = i + 1; j < i + 13; j++)
                {
                    currentProductValue *= int.Parse(inputNumber[j].ToString());
                }
                if (currentProductValue > largestProductValue)
                {
                    largestProductValue = currentProductValue;
                    largestProductStartingIndex = i;
                }
            }
            char[] largestProductElements = 
                inputNumber
                .Substring(largestProductStartingIndex, 13)
                .ToCharArray();
            Console.WriteLine($"{string.Join(" x ", largestProductElements)} = {largestProductValue}");
        }
    }
}
