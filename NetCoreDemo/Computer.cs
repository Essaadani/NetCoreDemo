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


    }
}
