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
            
            
            Console.WriteLine(example);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
