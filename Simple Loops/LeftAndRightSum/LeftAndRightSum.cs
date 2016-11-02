using System;

class LeftAndRightSum
    {
        static void Main()
        {
        int numbersCount = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            leftSum += currentNumber;

        }

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            rightSum += currentNumber;


        }
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", leftSum);
        }
        else
        {
            int diff = Math.Abs(leftSum - rightSum);
            Console.WriteLine("No, diff = {0}", diff);
        }
    }
    }


