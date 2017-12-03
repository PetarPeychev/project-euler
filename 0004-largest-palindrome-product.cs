using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;
            int firstLargestPalindromeComposite = 0;
            int secondLargestPalindromeComposite = 0;
            for (int i = 100; i <= 999 ; i++)
            {
                for (int j = 100; j <= 1099 - i; j++)
                {
                    int firstNumber = i;
                    int secondNumber = j + i - 100;
                    int multiple = firstNumber * secondNumber;
                    if (multiple == ReverseNumber(multiple))
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {multiple}");
                        if (multiple > largestPalindrome)
                        {
                            largestPalindrome = multiple;
                            firstLargestPalindromeComposite = firstNumber;
                            secondLargestPalindromeComposite = secondNumber;
                        }
                    }
                }
            }
            Console.WriteLine($"Largest Palindrome Pair: " +
                $"{firstLargestPalindromeComposite} * {secondLargestPalindromeComposite} = {largestPalindrome}");
        }

        static int ReverseNumber(int inputNumber)
        {
            int reversedNumber = 0;
            while (inputNumber != 0)
            {
                reversedNumber = reversedNumber * 10 + inputNumber % 10;
                inputNumber /= 10;
            }
            return reversedNumber;
        }
    }
}
