using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an odd or even number");
            string stringNumber1 = Console.ReadLine();
            Console.WriteLine("Enter the opposite number from the first");
            string stringNumber2 = Console.ReadLine();

            int number1 = int.Parse(stringNumber1);
            int number2 = int.Parse(stringNumber2);
            
            if (number1 % 2 == 0 && number2 % 2 == 0 ^ number2 % 2 == 0 || number1 % 2 == 0 )
            {
                Console.WriteLine("Number1 is even and Number2 is odd.");
            } else
            {
                Console.WriteLine("Number1 is odd and Number2 is even.");
            }
        }
    }
}
