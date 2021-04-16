using System;
using race.Classes;
namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver max = new Driver("Max",2);
            Driver ron = new Driver("Ron",5);
            Driver lana = new Driver("Lana",10);
            Driver rudi = new Driver("Rudi",8);

            Car hyndai = new Car("Hyndai","Max",130 );
            Car mazda = new Car("Mazda","Ron",170 );
            Car ferrari = new Car("Ferrari","Lana",350 );
            Car porsche = new Car("Porsche","Rudi",270 );
        }
    }
}
