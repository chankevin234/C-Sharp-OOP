using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2BInheritance
{
    class Drone : Bee
    {
    public Drone(string name, int honeyProduced) : base(name)
    {
            HoneyProduced = honeyProduced;
    }
    
    //property
    public int HoneyProduced { get; set; }
    }
    
}
