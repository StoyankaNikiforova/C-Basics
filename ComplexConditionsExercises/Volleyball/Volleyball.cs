using System;

class Volleyball
{
        static void Main()
        {
            string typeY = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double sat = ((48 - h) * 3.0)/4;
            double sund = h;
            double celebrates = (p * 2.0)/ 3;

        double allGames = sat + sund + celebrates;

        if (typeY == "leap")
        {
            allGames = allGames + ((allGames * 15) / 100);
        }
        Console.WriteLine(Math.Truncate(allGames));
        }
    }

