using System;
using exercise2.Class;
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter the dog's name");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Enter the dog's race");
            dog.Race = Console.ReadLine();
            Console.WriteLine("Enter the dog's color");
            dog.Color = Console.ReadLine();

            Console.WriteLine("Choose what you want to do with the dog:\nIf you want to feed the dog enter: 1\n" +
                "If you wanna play with the dog enter: 2\n" +
                "If you want the dog to chase its tail enter: 3.");
            int result;
            while (!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("You have entered a wrong number!");
                Console.WriteLine("Choose what you want to do with the dog:\nIf you want to feed the dog enter: 1\n" +
                "If you wanna play with the dog enter: 2\n" +
                "If you want the dog to chase its tail enter: 3.");
            }
            DogDoing(dog, result);
        }


        static void DogDoing(Dog dog, int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(dog.Eat());
                    break;
                case 2:
                    Console.WriteLine(dog.Play());
                    break;
                case 3:
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered a wrong input! Please try again.");
                    break;
            }
        }
    }
}
