using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2BInheritance
{
    class Beehive
    {
        public Beehive(string nameOfHive, Queen queen)
        {
            NameOfHive = nameOfHive;
            Queen = Queen;
            Drones = new List<Drone>();
        }
        public string NameOfHive { get; set; }
        public Queen Queen { get; set; }
        public List<Drone> Drones { get; set; }

    }
}
