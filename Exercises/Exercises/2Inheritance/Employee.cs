using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Employee : Person
    {
        //constructor
        public Employee(string name, string department) : base(name)
        {
            Department = department;
        }
        //property
        public string Department { get; set; }
    }
}
