using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Mammals : Animals
    {
        public int ChildrenInWormb { get; set; }
        
    }
    public interface IHerbivore
    {
        void EatGrass();
    }
    public interface ICarnivore
    {
        void EatMeat();
    }
    public interface IOmnivore
    {
        void EatMeaAndGrass();
    }
    public interface IFishEater
    {
        void EatFish();
    }



    class Rhino  : Mammals
    {
        public Rhino()
        {
            TypeOfAnimal = AnimalType.herbivore;
        }


        public Rhino(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Bellow";
            base.Age = 15;

            Console.WriteLine("\n Name of the Rhino is " + Name + "and I have" + NumberOfLegs + " legs and I sound " + Sound + " And My Age is " + Age + "\n");
        }
        public Rhino(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Bellow";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Rhino is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Plant");
        }
    }
    class Elephant : Mammals
    {
        public Elephant()
        {
            TypeOfAnimal = AnimalType.herbivore;
        }


        public Elephant(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Trump";
            base.Age = 15;

            Console.WriteLine("\n Name of the Elephant is " + Name + " and I have " + NumberOfLegs + " legs and I sound " + Sound + " And My Age is " + Age+ "\n");
        }
        public Elephant(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Trump";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Elephant is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Plant");
        }
    }
    class Bear : Mammals
    {
        public Bear()
        {
            TypeOfAnimal = AnimalType.carnivore;
        }


        public Bear(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Growl";
            base.Age = 15;

            Console.WriteLine("\n Name of the Bear is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + "And My Age is " + Age + " \n ");
        }
        public Bear(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Growl";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Bear is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Fish");
        }
    }
    class Giraffe : Mammals
    {
        public Giraffe()
        {
            TypeOfAnimal = AnimalType.herbivore;
        }


        public Giraffe(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Blead";
            base.Age = 15;

            Console.WriteLine("\n Name of the Giraffe is " + Name + " and I have " + NumberOfLegs + " legs and I sound " + Sound + " And My Age is " + Age+ "\n");
        }
        public Giraffe(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Blead";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Giraffe is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Plant");
        }
    }
    class Dolphin : Mammals
    {
        public Dolphin()
        {
            TypeOfAnimal = AnimalType.herbivore;
        }


        public Dolphin(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "whistles";
            base.Age = 15;

            Console.WriteLine("\n Name of the Dolphin is " + Name + " and I have " + NumberOfLegs + " legs and I sound " + Sound + " And My Age is " + Age);
        }
        public Dolphin(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "whistles";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Dolphin is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Fish");
        }
    }
    class Lion : Mammals
    {
        public Lion()
        {
            TypeOfAnimal = AnimalType.carnivore;
        }


        public Lion(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Roar";
            base.Age = 15;

            Console.WriteLine("\n Name of the Lion is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + "And My Age is" + Age);
        }
        public Lion(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Roar";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Lion is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Fish");
        }
    }
    class Tiger : Mammals
    {
        public Tiger()
        {
            TypeOfAnimal = AnimalType.carnivore;
        }


        public Tiger(string Name, string Sex, int Age)
        {
            base.Name = Name;
            base.NumberOfLegs = 4;
            base.Sound = "Roar";
            base.Age = 15;

            Console.WriteLine("\n Name of the Tiger is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " And My Age is" + Age);
        }
        public Tiger(string Name, string Sex, string childrenInWomb)
        {
            base.NumberOfLegs = 2;
            base.Sound = "Roar";
            base.NumberOfAniamalsInCages = 3;

            Console.WriteLine("\n Name of the Tiger is " + Name + "and I have" + NumberOfLegs + "legs and I sound" + Sound + " and " + NumberOfAniamalsInCages + "of animals in cage");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Meat");
        }
    }


}
