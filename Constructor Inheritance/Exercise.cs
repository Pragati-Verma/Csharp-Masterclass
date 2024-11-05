
using System;

namespace Coding.Exercise
{
    public class Person
    {
        // Declaring a constructor that takes a name and prints a message
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }
        public void PersonInfo()
        {
            Console.WriteLine($"Person constructor: {Name}");
        }
    }

    public class Employee : Person
    {
        // Declaring a constructor that takes a name and an ID, and calls the base class constructor
        public int Id { get; private set; }
        public Employee(string name, int id) : base(name)
        {
            Id = id;
        }
        public void EmployeeInfo()
        {
            PersonInfo();
            Console.WriteLine($"Employee constructor: {base.Name}, ID: {Id}");
        }
    }

    public class Exercise
    {
        public static void Main(string[] args)
        {
            // Creating an instance of Employee and print the messages
            Employee john = new Employee("John Doe",123);
            john.EmployeeInfo();
        }
    }
}

