using System;
using exercise3.Class;
namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[]
            {
                new Student("Kate","Caligraphy","G1"),
                new Student("Lana","Design","G2"),
                new Student("Layla","Programing","G3"),
                new Student("Ron","Programing","G3"),
                new Student("Desmond","Caligraphy","G1")
            };
            Console.WriteLine("Enter a student name!");
            string studentName = Console.ReadLine();
            FindStudent(studentArray, studentName);
        }

        static void FindStudent(Student[] students, string name)
        {
            bool foundStudent = false;
            while (foundStudent == false)
            {
                foreach(var student in students)
                {
                    if(name.ToLower() == student.Name.ToLower())
                    {
                        Console.WriteLine($"Student found!\nName: {student.Name} Academy: {student.Academy} Group: {student.Group}");
                        foundStudent = true;
                    }
                    
                }
                if (foundStudent == false)
                {
                    Console.WriteLine("We couldn't find a student with the given name! Please try again");
                    name = Console.ReadLine();
                }
            }
        }
        
    }
}
