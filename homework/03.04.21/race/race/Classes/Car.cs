using System;
using System.Collections.Generic;
using System.Text;

namespace race.Classes
{
    public class Car : Driver
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Skill * Speed;
        }
    };
}
