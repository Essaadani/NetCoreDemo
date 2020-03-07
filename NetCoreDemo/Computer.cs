using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDemo
{
    class Computer
    {
        //Properties
        private string brand;
        public double price;
        public DateTime manufactureDate;
        public string Color { get; set; }
        //Auto Properties
        public bool IsNew { get; set; }

        //Constructor
        public Computer()
        {
            this.brand = "Undefined";
            this.price = 0.0;
            this.manufactureDate = DateTime.Now;
            this.Color = "Undefined";
            this.IsNew = false;
        }

        public Computer(string _brand, double _price, DateTime _manufactureDate, string _color, bool _isNew)
        {
            brand = _brand;
            price = _price;
            manufactureDate = _manufactureDate;
            Color = _color;
            IsNew = _isNew;
        }
        //Access Modifiers: private, public, internal, protected

        //Full Properties
        public string Brand
        {
            get
            {
                return brand.ToUpper();
            }
            set
            {
                brand = value;
            }
        }

        // Methods
        public void Run()
        {
            Console.WriteLine("The computer is running...");
        }

        public int ProcessData()
        {
            return 1;
        }

        public IEnumerable<Computer> Find(string brand)
        {
            return null;
        }

        public IEnumerable<Computer> Find(DateTime manufactureDate)
        {
            return null;
        }

        public IEnumerable<Computer> Find(DateTime manufactureDate, string brand)
        {
            return null;
        }

        public Computer Find(int id)
        {
            return null;
        }

    }
}
