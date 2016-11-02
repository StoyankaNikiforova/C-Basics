using System;

class EqualPairs
    {
        static void Main()
        {

        int pairsCount = int.Parse(Console.ReadLine());
        double[] pairsSums = new double[pairsCount];
        int index = 0;
        double sum = 0;

            for (int i = 0; i < 2 * pairsCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (i % 2 != 0 )
                {
                    pairsSums[index] = sum;
                    index++;
                    sum = 0;
                }
            }
        bool isSumEquals = true;
        double maxdiff = 0;
        if (pairsCount > 1)
        {
             maxdiff = Math.Abs(pairsSums[0] - pairsSums[1]);
                    for (int i = 1; i < pairsCount; i++)
                    {
                        if (pairsSums[i] != pairsSums[i-1])
                        {
                            isSumEquals = false;
                            if (maxdiff < Math.Abs(pairsSums[i] - pairsSums[i-1]))
                            {
                                maxdiff = Math.Abs(pairsSums[i] - pairsSums[i - 1]);
                            }
                        }
                    }
        }
        
        if (isSumEquals)
        {
            Console.WriteLine("Yes, value={0}", pairsSums[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
        }
    }

