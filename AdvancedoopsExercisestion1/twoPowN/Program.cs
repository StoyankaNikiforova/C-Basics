using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoPowN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= n +1; i++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                
                number *= 2;
                
            }
        }
    }
}
