using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Merry", "Kate", "Ashley",};
            while (true)
            {
                Console.WriteLine("Please enter a new name:");
                string userName = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = userName;
                Console.WriteLine("Do you want to enter another name (Y/N)");
                string userAnswer = Console.ReadLine();

                while (userAnswer.ToUpper() != "Y" && userAnswer.ToUpper() != "N")
                {
                    Console.WriteLine("Sorry, you entered an invalid character!");
                    Console.WriteLine("Please enter Y/N");
                    userAnswer = Console.ReadLine();
                }
                if (userAnswer.ToUpper() == "N")
                {
                    break;
                }
            }
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                } 
            
        }
    }
}
