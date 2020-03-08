using System;

namespace NetCoreDemo
{
    class Designer : Person
    {
        public override void Walk()
        {
            throw new NotImplementedException();
        }

        public override void Work()
        {
            Console.WriteLine("I am designer");
        }
    }
}
