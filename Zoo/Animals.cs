using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animals
    {
        //private 
        //protected
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public int NumberOfCages { get; set; }
        public int NumberOfAniamalsInCages { get; set; }
        public float AmountOfFood { get; set; }
        public string TypeOfFood { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }
        public AnimalType TypeOfAnimal { get; set; }
        public float AnimalHeight { get; set; }



        public enum AnimalType
        {
    
            herbivore,carnivore,Omnivore
        }


        public Animals()
        {

        }

        public Animals(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine("I eat");
        }
    }
}
