using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Exercise
    {
        public static void Start()
        {
            Console.WriteLine("Starting...");
            //objects below
            Guitar gibson = new Guitar(Brand.Gibson, 10);
            //Guitar fender = new Guitar("Fender", 100);    
        
            Musician kevin = new Musician("Kevin", new Guitar(Brand.Fender, 1000)); //"gibson" is the value of the Guitar class instanstance which is a data type accepted into Musicians class
            Musician pontus = new Musician("Pontus", new Guitar(Brand.Gibson, 100));

            kevin.Play();
            pontus.Play();

            Console.WriteLine(kevin.Guitar.Price); //objectName.className.propertyName
        }
    }

    enum Brand
    { //default as int values
        Fender,
        Gibson,
        Ibanez
    }
}
