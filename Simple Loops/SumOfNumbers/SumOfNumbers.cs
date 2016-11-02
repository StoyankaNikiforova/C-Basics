using System;

class SumOfNumbers
    {
        static void Main()
        {
          int numbersCount = int.Parse(Console.ReadLine());
          int sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
              int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;
            }
        Console.WriteLine(sum);
    }
    }

