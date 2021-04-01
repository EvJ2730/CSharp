using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string secondNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);
            int number2 = int.Parse(secondNumber);

            Console.WriteLine("Before swaping");
            Console.WriteLine($"First number is : {number1}");
            Console.WriteLine($"Second number is : {number2}");

            int number = number1;
            number1 = number2;
            number2 = number;

            Console.WriteLine("After swaping");
            Console.WriteLine($"First number is now: {number1}");
            Console.WriteLine($"Second number is now: {number2}");
        }
    }
}
