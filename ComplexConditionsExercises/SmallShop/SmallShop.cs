using System;
using System.Collections.Generic;
    class SmallShop
    {
        static void Main()
        {
        Dictionary<string, Dictionary<string,double>> ProductsPrices = new Dictionary<string, Dictionary<string, double>>();

        ProductsPrices.Add("Sofia", new Dictionary<string, double>());
        ProductsPrices.Add("Plovdiv", new Dictionary<string, double>());
        ProductsPrices.Add("Varna", new Dictionary<string, double>());
        
        ProductsPrices["Sofia"].Add("coffee", 0.50);
        ProductsPrices["Sofia"].Add("water", 0.80);
        ProductsPrices["Sofia"].Add("beer", 1.20);
        ProductsPrices["Sofia"].Add("sweets", 1.45);
        ProductsPrices["Sofia"].Add("peanuts", 1.60);

        ProductsPrices["Plovdiv"].Add("coffee", 0.40);
        ProductsPrices["Plovdiv"].Add("water", 0.70);
        ProductsPrices["Plovdiv"].Add("beer", 1.15);
        ProductsPrices["Plovdiv"].Add("sweets", 1.30);
        ProductsPrices["Plovdiv"].Add("peanuts", 1.50);

        ProductsPrices["Varna"].Add("coffee", 0.45);
        ProductsPrices["Varna"].Add("water", 0.70);
        ProductsPrices["Varna"].Add("beer", 1.10);
        ProductsPrices["Varna"].Add("sweets", 1.35);
        ProductsPrices["Varna"].Add("peanuts", 1.55);

        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine(ProductsPrices[town][product] * price);

    }
}

