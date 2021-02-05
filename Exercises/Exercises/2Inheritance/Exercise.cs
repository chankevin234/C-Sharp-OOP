using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Exercise
    {
        public static void Start()
        {
            //create Employee subclass which pulls from Person
            //Employee kevin = new Employee("Kevin", "Marketing");
            //Consultant simran = new Consultant("Simran", 40, 8);

            //create Company base class
            Company manulife = new Company("Manulife");
            //add to List<Employee> in Company class
            manulife.Employees.Add(new Employee("Kevin", "Marketing"));
            manulife.Employees.Add(new Employee("Umair", "Data"));
            manulife.Employees.Add(new Employee("Melvin", "Engineering"));
            manulife.Consultants.Add(new Consultant("Simran", 40, 8));
            manulife.Consultants.Add(new Consultant("Matt", 45, 12));
            manulife.Consultants.Add(new Consultant("Maya", 35, 25));

            Console.WriteLine(manulife.Employees.Count);

        }
    }
}
