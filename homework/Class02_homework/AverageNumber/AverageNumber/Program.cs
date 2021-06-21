using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers!");
            Console.WriteLine("===============================");
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            int fourthNumber = int.Parse(Console.ReadLine());

            bool isFirstValid = Convert.ToBoolean(firstNumber);
            bool isSecondValid = Convert.ToBoolean(secondNumber);
            bool isThirdValid = Convert.ToBoolean(thirdNumber);
            bool isFourthValid = Convert.ToBoolean(fourthNumber);
            
            if(isFirstValid && isSecondValid && isThirdValid && isFourthValid)
            {
                int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                Console.WriteLine($"The average sum of: {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is equal to : {average}");
            }
            else
            {
                Console.WriteLine("One or more invalid input");
            }
        }
    }
}
