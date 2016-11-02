using System;
 class NumberFrom100to200
{
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int bufferNumber = number / 100;

            if (number < 0 || bufferNumber == 0)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number == 200 || bufferNumber == 1)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else 
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }

