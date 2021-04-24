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
            int number = Convert.ToInt32(Console.ReadLine());
            Queue myQueue = new Queue();
            foreach(int num in myQueue)
            {
                
                if(number < 0)
                {
                    Console.WriteLine("You have entered a wrong number");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
