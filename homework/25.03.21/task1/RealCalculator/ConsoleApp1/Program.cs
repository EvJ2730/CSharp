using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one number");
            string stringNumber1 = Console.ReadLine();
            int number1 = int.Parse(stringNumber1);

            Console.WriteLine("Enter another number");
            string stringNumber2 = Console.ReadLine();
            int number2 = int.Parse(stringNumber2);

            Console.WriteLine("Enter the wanted operator (+, -, /, *)");
            string math = Console.ReadLine();
            switch (math)
            {
                case "+":
                    Console.WriteLine(number1 + number2) ;
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("You have entered a wrong operator");
                    break;
            }

            //if (math == "+")
            //{
            //    Console.WriteLine(number1 + number2);
            //}
            //else if (math == "-")
            //{
            //    Console.WriteLine(number1 - number2);
            //}
            //else if (math == "*")
            //{
            //    Console.WriteLine(number1 * number2);
            //}
            //else if (math == "/")
            //{
            //    Console.WriteLine(number1 / number2);
            //}
            //else
            //{
            //    Console.WriteLine("You've entered an invalid number!");
            //}
        }
    }
}
