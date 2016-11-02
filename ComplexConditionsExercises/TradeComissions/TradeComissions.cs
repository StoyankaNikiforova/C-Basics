using System;
using System.Collections.Generic;

 class TradeComissions
    {
        static void Main()
        {

        Dictionary<string, double[]> tradeComissions = new Dictionary<string, double[]>()
            {
                { "Sofia", new double[] { 5, 7, 8, 12 }},
                { "Plovdiv", new double[] { 5.5, 8, 12, 14.5 }},
                { "Varna", new double[] { 4.5, 7.5, 10, 13}}
            };

        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double comission = 0;
        double coefic = 0;

        if (quantity > 0 && tradeComissions.ContainsKey(town))
        {
            if (0 <= quantity && quantity <= 500)
            {
                coefic = tradeComissions[town][0];
            }
            else if (500 < quantity && quantity <= 1000)
            {
                coefic = tradeComissions[town][1];
            }
            else if (1000 < quantity && quantity <= 10000)
            {
                coefic = tradeComissions[town][2];
            }
            else
            {
                coefic = tradeComissions[town][3];
            }
            comission = (quantity * coefic)/ 100;
            Console.WriteLine("{0:f2}", comission);
        }
        else
        {
            Console.WriteLine("error");
        }
           
        }
    }

