using System;

class OddevenPosition
    {
        static void Main()
        {
        int numbersCount = int.Parse(Console.ReadLine());
        double OddSum = 0;
        double OddMin = double.MaxValue;
        double OddMax = double.MinValue;
        double EvenSum = 0;
        double EvenMin = double.MaxValue;
        double EvenMax = double.MinValue;

        for (int i = 0; i < numbersCount; i++)
        {
            double num = double.Parse(Console.ReadLine());
            
            if (i % 2 != 0)
            {
                EvenSum += num;
                if (num > EvenMax)
                {
                    EvenMax = num;
                }
                if (num < EvenMin)
                {
                    EvenMin = num;
                }

            }
            else
            {
                OddSum += num;
                if (num > OddMax)
                {
                    OddMax = num;
                }
                if (num < OddMin)
                {
                    OddMin = num;
                }
            }
        }

        Console.WriteLine("OddSum={0},", OddSum);
        if (OddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin=No");
        }
        else
        {
            Console.WriteLine("OddMin={0},",OddMin);
        }
        if (OddMax == double.MinValue)
        {
            Console.WriteLine("OddMax=No");
        }
        else
        {
            Console.WriteLine("OddMax={0},", OddMax);
        }
        Console.WriteLine("EvenSum={0},", EvenSum);
        if (EvenMin == double.MaxValue)
        {
            Console.WriteLine("EvenMin=No");
        }
        else
        {
            Console.WriteLine("EvenMin={0},", EvenMin);
        }
        if (EvenMax == double.MinValue)
        {
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine("EvenMax={0}", EvenMax);
        }
    }
    }

