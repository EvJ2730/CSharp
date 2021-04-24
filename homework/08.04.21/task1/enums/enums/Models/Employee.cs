using System;
using System.Collections.Generic;
using System.Text;
using Models.Enums;
namespace enums.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Role { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
