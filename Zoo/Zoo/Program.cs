using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects are the actual "building"
            
            //Animal cat = new Animal(4.5);
            //Animal dog = new Animal(10);

            //Console.WriteLine(cat.Weight);
            //Console.WriteLine(dog.Weight);

            Cat cat = new Cat();
            Dog dog = new Dog(10);

            
        }
    }

    //blueprint - 1 per type
    abstract class Animal //abstract classes can't be instantiated as an object --> only used for inheriting
    {
        public Animal(double weight)
        {// starting required properties
            Weight = weight;
        }
        public double Weight { get; set; } //property
    }
    
    class Cat : Animal //Cat inherits from Animal
    {
        public Cat() : base(4.5) // base prevents code within this constructor from running and uses base value of the parent class
        {
            //weight property is assigned as 4.5 automatically
        }

    }

    class Dog : Animal
    {
        public Dog(double weight) : base(weight) //pass dog weight into constructor
        {

        }
    }
}
