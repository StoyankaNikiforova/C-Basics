using System;
using System.Collections.Generic;

class VowelsSum
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            Dictionary<char, int> vowelesColection = new Dictionary<char, int>(){
                {'a',1 },
                {'e',2 },
                {'i',3 },
                {'o',4 },
                {'u',5 }
            };

        int sum = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowelesColection.ContainsKey(inputString[i]))
                {
                    sum += vowelesColection[inputString[i]];
                }
            }
        Console.WriteLine(sum);
        }
    }

