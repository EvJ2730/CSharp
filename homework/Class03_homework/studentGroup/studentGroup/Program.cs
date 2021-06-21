using System;

namespace studentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstGroup = new string[5] { "Angel", "Goce", "Petre", "Martin", "Nikola" };
            string[] secondGroup = new string[5] { "Daniel", "Goran", "Bojan", "Vasil", "Dragan" };
            Console.Write("STUDENT GROUPS -> Insert 1 or 2 to see the students in those groups: ");
        checkpoint:
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int groupNumber);
            Console.WriteLine("");
            if (groupNumber == 1)
            {
                Console.WriteLine("Students of G1: ");
                foreach (var student in firstGroup)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupNumber == 2)
            {
                Console.WriteLine("Students of G2: ");
                foreach (var student in secondGroup)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.Write("We only have G1 and G2 (Insert 1 or 2): ");
                goto checkpoint;
            }
        }
    }
}
