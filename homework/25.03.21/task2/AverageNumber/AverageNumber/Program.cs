using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string number2 = Console.ReadLine();
            Console.WriteLine("And another, please");
            string number3 = Console.ReadLine();
            Console.WriteLine("This is the last one i promise");
            string number4 = Console.ReadLine();

            bool conversionSuccess1 = float.TryParse(number1, out float convertedNumber1);
            bool conversionSuccess2 = float.TryParse(number2, out float convertedNumber2);
            bool conversionSuccess3 = float.TryParse(number3, out float convertedNumber3);
            bool conversionSuccess4 = float.TryParse(number4, out float convertedNumber4);
           

            if (conversionSuccess1 && conversionSuccess2 && conversionSuccess3 && conversionSuccess4)
            {
                Console.WriteLine($"The average is: {(convertedNumber1 + convertedNumber2 + convertedNumber3 + convertedNumber4) / 4}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have entered an invalid number!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
    }
}
