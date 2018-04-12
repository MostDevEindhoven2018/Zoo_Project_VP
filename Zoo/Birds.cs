﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Bird : Animals
    {
        public int NumberOfWings { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Ï eat insects");
        }

    }

    public class Owl : Bird
    {
        public Owl()
        {
            base.TypeOfAnimal = AnimalType.carnivore;
            base.NumberOfWings = 2;
        }
        public Owl(string name, float height):this()
        {
            NumberOfLegs = 2;
            Name = name;
            
            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat small insects and fishes\n");
        }

    }

    public class Penguin : Bird
    {
        public Penguin()
        {
            
            base.NumberOfWings = 2;
        }
        public Penguin(string name, float height):this()
        {

            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"I am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat algae\n");
        }

    }

    public class Parrot : Bird
    {

        public Parrot()
        {
            base.TypeOfAnimal = AnimalType.herbivore;
            base.NumberOfWings = 2;
        }
        public Parrot(string name, float height):this()
        {

            base.Name = name;
            base.AnimalHeight = height;

            Console.WriteLine($"\nI am {base.Name} of type Mammal, I got {base.NumberOfLegs} legs and I'm {base.AnimalHeight} cms\n");
        }

        public override void Eat()
        {
            Console.WriteLine("I only eat seeds\n");
        }

    }

}