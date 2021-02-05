using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2BInheritance
{
    class Exercise
    {
        public static void Start()
        {
            Queen tanya = new Queen("Tanya");
            Drone sarah = new Drone("Sarah", 12);

            Beehive beeMovie = new Beehive("BeeMovie", tanya);
            beeMovie.Drones.Add(new Drone("Charlie", 15));
            beeMovie.Drones.Add(new Drone("Sally", 150));
            beeMovie.Drones.Add(sarah);
        }
    }
}
