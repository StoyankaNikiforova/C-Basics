using System;
 class SumSeconds
    {
        static void Main(string[] args)
        {
            int SumSecond = 0;

            for (int i = 0; i < 3; i++)
            {
                SumSecond += int.Parse(Console.ReadLine());
            }

            int minutes = SumSecond / 60;
            int seconds = SumSecond % 60;
            string secondsFinal = seconds + "";

                if (seconds< 10)
                {
                   secondsFinal = "0" + secondsFinal;
                }
            Console.WriteLine("{0}:{1}", minutes, secondsFinal);
    }
    }

