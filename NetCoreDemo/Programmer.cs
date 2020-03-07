using System;

namespace NetCoreDemo
{
    class Programmer : Person
    {
        public double Salary { get; set; }

        public Programmer(string name, string address, byte age, double salary)
            : base(name, address, age)
        {
            this.Salary = salary;
        }

        public Programmer()
        {

        }
        public void UseProgrammingLanguage(string language)
        {
            Console.WriteLine("I program with : " + language);
        }

        public override void Work()
        {
            Console.WriteLine("I am programmer");
        }

        public new void Speak()
        {
            Console.WriteLine("I Speak C#...");
        }

    }
}
