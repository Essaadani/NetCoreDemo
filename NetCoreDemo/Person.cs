using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDemo
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }

        public Person(string name, string address, byte age)
        {
            Name = name;
            Address = address;
            Age = age;
        }
        public void Speak()
        {
            Console.WriteLine("I Speak...");
        }

        public void Work()
        {
            Console.WriteLine("I Work...");
        }
    }

    class Programmer : Person
    {
        public double Salary { get; set; }

        public Programmer(string name, string address, byte age, double salary)
            : base(name, address, age)
        {
            this.Salary = salary;
        }
        public void UseProgrammingLanguage(string language)
        {
            Console.WriteLine("I program with : " + language);
        }
    }
}
