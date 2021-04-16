using System;
using exercise1.Class;
namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human inputHuman = HumanInput();
            static Human HumanInput()
            {
                Human human = new Human();
                Console.WriteLine("Enter human's first name");
                human.FirstName = Console.ReadLine();
                Console.WriteLine("Enter human's last name");
                human.LastName = Console.ReadLine();
                Console.WriteLine("Enter human's age");
                human.Age = int.Parse(Console.ReadLine());
                return human;
            }
            Console.WriteLine(inputHuman.GetPersonStats());
        }
    }
}