using System;

class MaxNumber
    {
        static void Main()
        {
        int numbersCount = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
            
        }
        Console.WriteLine(maxNumber);

    }
}
