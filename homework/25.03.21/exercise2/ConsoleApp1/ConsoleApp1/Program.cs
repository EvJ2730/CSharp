using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 3 and type it.");
            string stringNumber1 = Console.ReadLine();
            int number1 = int.Parse(stringNumber1);

            switch (number1)
            {
                case 1 :
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered a wrong number");
                    break;
            }

        }
    }
}
