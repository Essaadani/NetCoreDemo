using System;
using static System.Console;

namespace NetCoreDemo
{
    class Program
    {
        static Computer myComputer = new Computer();
        static void Main(string[] args)
        {
            Person person = new Person();

            Programmer programmer = new Programmer();

            person.Work(); // virtual

            programmer.Work(); // override

            person.Speak();
            programmer.Speak();
            // Overriding

            // Hiding - Shadowing
        }
    }
    
}
