using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>(); // instantiating new list filled with employee data types
            Consultants = new List<Consultant>();
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Consultant> Consultants { get; set; }
    }
}
