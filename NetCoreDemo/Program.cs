using System;
using static System.Console;

namespace NetCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            persons[0] = new Programmer();
            persons[1] = new Designer();
            persons[2] = new Analyst();

            foreach (Person person in persons)
            {
                person.Work();
            }
        }
    }
}
