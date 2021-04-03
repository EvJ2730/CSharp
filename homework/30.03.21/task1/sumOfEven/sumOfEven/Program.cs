using System;

namespace sumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[6];
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number");
                int numbers = Convert.ToInt32(Console.ReadLine());
                numberArray[i] = numbers;
                if(numbers % 2 == 0)
                {
                    sum += numbers;
                    Console.Write("---------Even number");
                } return;
            }
            Console.WriteLine("The Sum of every even muber is: " + sum);
        }
    }
}
