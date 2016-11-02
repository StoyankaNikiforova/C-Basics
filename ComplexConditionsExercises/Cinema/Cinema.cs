using System;

class Cinema
    {
        static void Main()
        {
        string typePr = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int colls = int.Parse(Console.ReadLine());
        double price = 0;
        switch (typePr)
        {
            case "Premiere":
                price = 12.00;
                break;
            case "Normal":
                price = 7.50;
                break;
            case "Discount":
                price = 5.00;
                break;
        }
        double result = rows * colls * price;
        Console.WriteLine("{0:f2} leva", result);
    }
}

