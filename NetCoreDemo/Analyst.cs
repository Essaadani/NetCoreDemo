using System;

namespace NetCoreDemo
{
    class Analyst : Person
    {
        public override void Walk()
        {
            throw new NotImplementedException();
        }

        public override void Work()
        {
            Console.WriteLine("I am analyst");
        }
    }
}
