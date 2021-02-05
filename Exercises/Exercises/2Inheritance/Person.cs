using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    abstract class Person : Object //base class... Object is default base class
    {
        //constructor
        public Person(string name) : base()
        {
            Name = name;
        }
        //properties
        public string Name { get; set; }
    }

}
