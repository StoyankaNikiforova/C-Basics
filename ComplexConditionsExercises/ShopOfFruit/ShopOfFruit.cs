using System;
using System.Collections.Generic;
class ShopOfFruit
{
    static void Main()
    {
        Dictionary<string, double[]> priceOfFruits = new Dictionary<string, double[]>()
            {
                { "banana", new double[] { 2.50, 2.70 } },
                { "apple", new double[] { 1.20, 1.25 } },
                { "orange", new double[] { 0.85, 0.90 } },
                { "grapefruit", new double[] { 1.45, 1.60 } },
                { "kiwi", new double[] { 2.70, 3.00 } },
                { "pineapple", new double[] { 5.50, 5.60 } },
                { "grapes", new double[] { 3.85, 4.20 } }
            };

        List<string> weekend = new List<string>()
           {
               "Saturday","Sunday"
           };
        List<string> weekday = new List<string>()
           {
               "Monday","Tuesday", "Wednesday", "Thursday", "Friday"
           };

        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        if (quantity > 0 && (weekday.Contains(day) || weekend.Contains(day)) && priceOfFruits.ContainsKey(fruit))
        {
            if (weekday.Contains(day))
            {
                Console.WriteLine("{0:f2}", quantity * priceOfFruits[fruit][0]);
            }
            else
            {
                Console.WriteLine("{0:f2}", (quantity * priceOfFruits[fruit][1]));
            }

        }
        else
        {
            Console.WriteLine("error");
        }
    }
} 
    

