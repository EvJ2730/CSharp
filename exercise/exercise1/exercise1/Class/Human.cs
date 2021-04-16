using System;
using System.Collections.Generic;
using System.Text;

namespace exercise1.Class
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            return string.Format($"Name: {FirstName}\nLast name: {LastName}\nage: {Age}");
        }
    }
}
