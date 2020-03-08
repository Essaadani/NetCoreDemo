using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDemo
{
    abstract class Person : IPerson
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

        public Person()
        {

        }
        public void Speak()
        {
            Console.WriteLine("I Speak...");
        }

        public virtual void Work()
        {
            Console.WriteLine("I Work...");
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }

        public int GetAge(DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
