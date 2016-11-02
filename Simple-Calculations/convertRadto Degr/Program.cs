using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertRadto_Degr
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double degr = rad * 180/Math.PI;

            Console.WriteLine(Math.Round(degr, 0));
        }
    }
}
