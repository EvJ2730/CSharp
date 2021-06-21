using System;

namespace sumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[6];
            int sumOfEven = 0;
            Console.WriteLine("INSERT SIX NUMBERS");
            Console.WriteLine("");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write($"{i + 1}. Number: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int parsedNumber);
                if (parsedNumber % 2 == 0)
                {
                    sumOfEven += parsedNumber;
                }
            }
            Console.WriteLine($"The sum of all even numbers you entered is: {sumOfEven}");
        }
    }
}
