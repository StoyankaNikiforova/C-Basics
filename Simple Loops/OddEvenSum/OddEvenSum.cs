using System;

class OddEvenSum
    {
        static void Main()
        {
        int numbersCount = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += currentNumber;
            }
            else
            {
                oddSum += currentNumber;
            }
           
            

        }

        
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum = {0}", oddSum);
        }
        else
        {
            int diff = Math.Abs(oddSum - evenSum);
            Console.WriteLine("No, diff = {0}", diff);
        }
    }
    }

