using System;

class HalfSum
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbersColection = new int[numbersCount];
            int sumOfnumbers = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbersCount; i++)
                    {
                        int currentNum = int.Parse(Console.ReadLine());
                        numbersColection[i] = currentNum;
                        sumOfnumbers += currentNum;
                if (numbersColection[i] > maxNumber)
                {
                    maxNumber = numbersColection[i];
                }
            }

        bool isNumberEvenSum = false;
        int number = 0;        
        for (int i = 0; i < numbersCount; i++)
            {
                if (numbersColection[i] == sumOfnumbers - numbersColection[i])
                {
                isNumberEvenSum = true;
                number = numbersColection[i];
                }
            }


        if (isNumberEvenSum)
        {
            Console.WriteLine("Yes!\nSum = {0}", number);
        }
        else
        {
            Console.WriteLine("No!\nDiff = {0}", Math.Abs(maxNumber - (sumOfnumbers - maxNumber)));
        }

    }
    }

