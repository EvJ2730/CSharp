using System;

namespace studentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = new string[] { "John", "Josh", "Johnny", "Jack", "Jackson" };
            string[] group2 = new string[] { "Tiffany", "Sara", "Abby", "Magie", "Kte"};
            Console.WriteLine("Enter a number between 1 and 2");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Array.ForEach(group1, Console.WriteLine);
                    break;
                case 2:
                    Array.ForEach(group2, Console.WriteLine);
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered a wrong number");
                    break;
            }
        }
    }
}
