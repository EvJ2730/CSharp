using System;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveSpaces();
        }

        static void RemoveSpaces()
        {
            string example = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            var chars = example.ToCharArray();
            var charsString = string.Empty;

            foreach (var eachChar in chars)
            {
                if(eachChar != ' ')
                {
                    charsString += eachChar; 
                }
               
            }
            Console.WriteLine(charsString);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(example);
            
        }
    }
}
