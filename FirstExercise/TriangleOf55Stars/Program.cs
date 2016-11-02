using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowLenght = 0;
            for (int i = 0; i < 10; i++)
            {
                RowLenght++;

                for (int j = 0; j < RowLenght; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
