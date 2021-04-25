using System;
using System.Collections.Generic;
using System.Text;

namespace race.Classes
{
    public class Car 
    {
        public  Driver Driver { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }
    };
}
