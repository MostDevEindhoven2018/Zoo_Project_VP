using System;
using System.Collections.Generic;

namespace Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {


            List<Animals> listofanimals = new List<Animals>();
            listofanimals.Add(new Bear("bear_ABC", "male", 5));
            listofanimals.Add(new Elephant("Elephant_ABC", "Male", 2));
            listofanimals.Add(new Dolphin("Dolphin_ABC", "Male", 12));
            listofanimals.Add(new Giraffe("Girafee_ABC", "Male", 14));
            listofanimals.Add(new Rhino("Rhino_ABC", "Male", 35));
            listofanimals.Add(new Aligator("Aligator_ABC", 5));
            listofanimals.Add(new Parrot("Parrot_ABC", 4));

            int countOfCarnivore=0;

            for (int i = 0; i < listofanimals.Count; i++)
            {
                if(listofanimals[i].TypeOfAnimal == Animals.AnimalType.carnivore)
                {
                    countOfCarnivore++;
                }
            }
           // Console.WriteLine(countOfCarnivore); 

            int countofherbivore = 0;
            
            for (int i = 0; i < listofanimals.Count; i++)
            {
                if(listofanimals[i].TypeOfAnimal==Animals.AnimalType.herbivore)
                {
                    countofherbivore++;
                }
            
             }
          

            int countofOmnivore = 0;
            for (int i = 0; i < listofanimals.Count; i++)
            {
                if (listofanimals[i].TypeOfAnimal == Animals.AnimalType.Omnivore)
                {
                    countofherbivore++;
                }

            }
            Console.WriteLine($" zoo park contains  {countofOmnivore}  no of Omnivore ");
            Console.WriteLine($" zoo park contains  {countOfCarnivore}  no of Carnivore ");
            Console.WriteLine($" zoo park contains  {countofherbivore}  no of Herbivore \n");

            Console.WriteLine("ZOO provide food to animals (Y/N): ");
            string UserInput = Console.ReadLine();

            if (UserInput.Equals("Y") || UserInput.Equals("y"))
            {
                Console.WriteLine(" All herbivore, carnivore and Omnivore are safe and Happy ;-) ");
            }
            else if (UserInput.Equals("N")|| UserInput.Equals("n"))
            {
                Console.WriteLine(" Animals are staving Provide Food ");
                Console.WriteLine(" Would you like to provide food for animals (Y/N): ");

                Console.WriteLine($"first user input if: {UserInput}");

                UserInput = Console.ReadLine();

                Console.WriteLine($"second user input if: {UserInput}");

                if (UserInput.Equals("Y") || UserInput.Equals("y"))
                {
                    Console.WriteLine(" All herbivore, carnivore and Omnivore are safe and Happy ;-) ");
                }
                else if (UserInput.Equals("N") || UserInput.Equals("n"))
                {
                    Console.WriteLine(" Animals are staving Provide Food ");
                }

            }

           


            //Bear bear_123 = new Bear();
            //bear_123.Eat();

            //Elephant Elephant_123 = new Elephant();
            //Elephant_123.Eat();


            //Dolphin dolphin_123 = new Dolphin();
            //dolphin_123.Eat();

            //Giraffe giraffe_123 = new Giraffe();
            //giraffe_123.Eat();

            //Rhino rhino_123 = new Rhino();
            //rhino_123.Eat();

            //Aligator aligator_123 = new Aligator();
            //aligator_123.Eat();

            //Parrot parrot_123 = new Parrot();
            //parrot_123.Eat();



            Console.ReadKey();
        }
    }
}
