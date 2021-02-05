using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Guitar
    {
        //constructor
        public Guitar(Brand brand, int price)
        {
            //properties
            Brand = brand;
            Price = price;
        }
        //properties
        public Brand Brand { get; set; }
        public int Price { get; set; }
    }
}
