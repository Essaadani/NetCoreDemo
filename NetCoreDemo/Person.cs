using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDemo
{
    abstract class Person
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

        public abstract void Walk();

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
    }
}
