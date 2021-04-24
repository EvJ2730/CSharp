using race.Classes;
using System;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Eva", 5);
            Driver driver2 = new Driver("Arthur", 2);
            Driver driver3 = new Driver("Mona", 4);
            Driver driver4 = new Driver("Bobby", 3);
            
            Car car1 = new Car("Hundai", 320, driver1);
            Car car2 = new Car("Mazda", 235, driver2);
            Car car3 = new Car("Ferrari", 450, driver3);
            Car car4 = new Car("Porsche", 520, driver4);

            int CalculateSpeed1() => car1.Speed * driver1.Skill;
            int CalculateSpeed2() => car2.Speed * driver2.Skill;
            int CalculateSpeed3() => car3.Speed * driver3.Skill;
            int CalculateSpeed4() => car4.Speed * driver4.Skill;

            Console.WriteLine(CalculateSpeed1() + $"This is the speed of {car1.Model} and {driver1.Name}");
            Console.WriteLine(CalculateSpeed2() + $"This is the speed of {car2.Model} and {driver2.Name}");
            Console.WriteLine(CalculateSpeed3() + $"This is the speed of {car3.Model} and {driver3.Name}");
            Console.WriteLine(CalculateSpeed4() + $"This is the speed of {car4.Model} and {driver4.Name}");
           
        }
    }
}
