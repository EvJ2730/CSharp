using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("==========================");
            bool isFirstValid = Convert.ToBoolean(firstNumber);
            bool isSecondValid = Convert.ToBoolean(secondNumber);

            if(isFirstValid && isSecondValid)
            {
                int swap;
                swap = secondNumber;
                secondNumber = firstNumber;
                firstNumber = swap;
                Console.WriteLine( $"First number after the swap is: {firstNumber}." +
                                   $"Second number after the swap is: {secondNumber}") ;
            }
            else
            {
                Console.WriteLine("One or more invalid inputs!");
            }

        }
    }
}
