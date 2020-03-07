using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDemo
{
    class Computer
    {
        //Properties
        private string Brand;
        public double price;
        public DateTime ManufactureDate;
        public string Color { get; set; }
        //Auto Properties
        public bool isNew { get; set; }

        //Constructor
        public Computer()
        {
            this.Brand = "Undefined";
            this.price = 0.0;
            this.ManufactureDate = DateTime.Now;
            this.Color = "Undefined";
            this.isNew = false;
        }

        public Computer(string _brand, double _price, DateTime _manufactureDate, string _color, bool _isNew)
        {
            Brand = _brand;
            price = _price;
            ManufactureDate = _manufactureDate;
            Color = _color;
            isNew = _isNew;
        }
        //Access Modifiers: private, public, internal, protected

        //Full Properties
        public string BrandProperty
        {
            get
            {
                return Brand.ToUpper();
            }
            set
            {
                Brand = value;
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
    }
}
