using System;
using System.Collections.Generic;

    class FrutOrVegetable
    {
        static void Main()
        {
                List<string> vegetables = new List<string>()
                {
                    "tomato", "cucumber", "pepper", "carrot"
                };
                List<string> fruit = new List<string>()
                {
                    "banana", "apple", "kiwi", "cherry", "lemon", "grapes"
                };

                string foodName = Console.ReadLine();

        if (vegetables.Contains(foodName))
        {
            Console.WriteLine("vegetable");
        }
        else if (fruit.Contains(foodName))
        {
            Console.WriteLine("fruit");
        }
        else
        {
            Console.WriteLine("unknown");
        }

        }
    }

