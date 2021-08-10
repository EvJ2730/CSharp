using System;

namespace studentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstGroup = new string[5] { "Angela", "Eva", "Sotir", "Martin", "Jana" };
            string[] secondGroup = new string[5] { "Daniel", "Bojana", "Lina", "Martin", "Ana" };
            Console.Write("STUDENT GROUPS => Insert 1 to see the students in the first group." +
                                            "Insert 2 to see the students in the second group");
        checkpoint:
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int groupNumber);
            Console.WriteLine("");
            if (groupNumber == 1)
            {
                Console.WriteLine("Students of First Group: ");
                foreach (var student in firstGroup)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupNumber == 2)
            {
                Console.WriteLine("Students of Second Group: ");
                foreach (var student in secondGroup)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.Write("We only have First Group and Second Group (Insert 1 or 2): ");
                goto checkpoint;
            }
        }
    }
}
