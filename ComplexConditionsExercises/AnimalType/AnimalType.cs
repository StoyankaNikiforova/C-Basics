using System;
 class AnimalType
    {
        static void Main()
        {
                string animalName = Console.ReadLine();

                if (animalName == "dog")
                {
                    Console.WriteLine("mammal");
                }
                else if (animalName == "crocodile" || animalName == "snake" || animalName == "tortoise")
                {
                    Console.WriteLine("reptile");
                }
                else
                {
                Console.WriteLine("unknown");
                }
        }
    }

