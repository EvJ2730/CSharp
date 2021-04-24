using System;
using System.Collections.Generic;
using System.Text;

namespace exercise2.Class
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string Eat()
        {
            return $"{Name} is now eating";
        }
        public string Play()
        {
            return $"{Name} is now playing";
        }
        public string ChaseTail()
        {
            return $"{Name} is now chasing its tail";
        }
    }
}
