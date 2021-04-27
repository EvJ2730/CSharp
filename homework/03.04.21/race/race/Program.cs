using race.Classes;
using System;
using System.Collections.Generic;
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

            Console.WriteLine(car1.CalculateSpeed());

            
        }
        
        static string RaceCars()
        {
            Console.WriteLine("Plese enter a type of car");
            string userCar = Console.ReadLine();
            if(userCar == car1.Model)
            {
                Console.WriteLine($"Your car is {car1.Model}");
                
            }
        }
    }
}
