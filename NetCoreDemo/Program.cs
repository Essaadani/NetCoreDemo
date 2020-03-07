using System;
using static System.Console;

namespace NetCoreDemo
{
    class Program
    {
        static Computer myComputer = new Computer();
        static void Main(string[] args)
        {
            myComputer.BrandProperty = "Compaq";
            myComputer.Color = "Silver";
            myComputer.isNew = true;
            myComputer.price = 45.50;
            myComputer.ManufactureDate = new DateTime(2019, 02, 15);

            int number = myComputer.ProcessData();

            WriteLine(myComputer.BrandProperty);
            myComputer.Run();

            Computer Comp1 = new Computer();
            WriteLine(Comp1.BrandProperty);

            Computer Comp2 = new Computer("HP", 500.00, new DateTime(2019, 02, 14), "Gray", true);

            WriteLine($"Brand = {Comp2.BrandProperty}\nPrice={Comp2.price}\nDate={Comp2.ManufactureDate}\nColor={Comp2.Color}");

            Person per = new Person("Ahmed","Egypt",32);

            Programmer p = new Programmer("Khalid", "Morocco", 29, 3560);

            p.UseProgrammingLanguage("Python");
        }
    }
    
}
