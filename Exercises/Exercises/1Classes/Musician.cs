using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Musician
    {
        //constructor
        public Musician(string name, Guitar guitar) //Guitar --> full Guitar object
        {
            Name = name;
            Guitar = guitar; 
        } 
        //properties
        public string Name { get; set; } 
        public Guitar Guitar { get; set; } //use "Guitar" data type which includes weight, price, nameofGuitar
        
        //method
        public void Play()
        {
            Console.WriteLine($"{Name} plays the {Guitar.Brand} guitar"); //$ allows for string interpolation
        }
    }
}
