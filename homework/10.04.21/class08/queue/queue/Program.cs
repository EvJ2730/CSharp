using System;
using System.Collections;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            Queue myQueue = new Queue();

            while (true)
            {
                Console.WriteLine("Do you want to enter a new number (Y/N)?");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    Console.WriteLine("Please enter a number");
                }
                else
                {
                    break;
                }

            }
            //foreach(int num in myQueue)
            //{
                
            //    if(number < 0)
            //    {
            //        Console.WriteLine("You have entered a wrong number");
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
        }
    }
}
