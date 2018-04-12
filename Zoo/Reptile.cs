using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Reptile : Animals
    {
        protected double length { get; set; }
        protected int NoOfEggs { get; set; }
    }

    public class Chamelon : Reptile
    {
        public Chamelon()
        {
            
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfLegs = 2;
        }
        public Chamelon(string name, float height) : this()
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;
            base.NoOfEggs = 5;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat Insect \n");
        }

    }

    public class Aligator : Reptile
    {
        public Aligator()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfLegs = 4;
        }
        public Aligator(string name, float height) : this()
        {
            base.NumberOfLegs = 0;
            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"\n I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms\n");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat all kinds of fishes\n");
        }

    }
}




