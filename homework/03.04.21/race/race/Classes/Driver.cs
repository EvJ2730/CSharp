using System;
using System.Collections.Generic;
using System.Text;

namespace race.Classes
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
        Driver driver1 = new Driver("Eva", 5);
        Driver driver2 = new Driver("Arthur", 2);
        Driver driver3 = new Driver("Mona", 4);
        Driver driver4 = new Driver("Bobby", 3);
    }
}
