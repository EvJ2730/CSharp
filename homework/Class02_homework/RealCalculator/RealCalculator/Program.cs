using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers!");
            Console.WriteLine("=================================");
            Console.WriteLine("Enter the first number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operator (+ ; - ; * ; /)");
            string Operator = Console.ReadLine();

            double result;
            switch (Operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("You have chosen an invalid operator");
                    break;
            }

        }
    }
}
