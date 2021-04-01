using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[5];
            int sum = 0;
            for(int i = 0; i<numberArray.Length; i++)
            {
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter a number");
                //Console.ForegroundColor = ConsoleColor.Cyan;
                int parse = int.Parse(Console.ReadLine());
                numberArray[i] = parse;
                sum += numberArray[i];
            }
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------");
            Console.WriteLine("The SUM is: " + sum);
            //Console.ForegroundColor = ConsoleColor.Black;
        }

    }
}

