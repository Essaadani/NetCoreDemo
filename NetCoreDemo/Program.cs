using System;
using static System.Console;

namespace NetCoreDemo
{
    class Program
    {
        static Computer myComputer = new Computer();
        static void Main(string[] args)
        {
            myComputer.Brand = "Compaq";
            myComputer.Color = "Silver";
            myComputer.IsNew = true;
            myComputer.price = 45.50;
            myComputer.manufactureDate = new DateTime(2019, 02, 15);

            int number = myComputer.ProcessData();

            WriteLine(myComputer.Brand);
            myComputer.Run();

            Computer firstComputer = new Computer();
            WriteLine(firstComputer.Brand);

            Computer secondComputer = new Computer("HP", 500.00, new DateTime(2019, 02, 14), "Gray", true);

            WriteLine($"Brand = {secondComputer.Brand}" +
                        $"\nPrice={secondComputer.price}" +
                        $"\nDate={secondComputer.manufactureDate}" +
                        $"\nColor={secondComputer.Color}");

            Person person = new Person("Ahmed","Egypt",32);

            Programmer programmer = new Programmer("Khalid", "Morocco", 29, 3560);

            programmer.UseProgrammingLanguage("Python");
        }
    }
    
}
