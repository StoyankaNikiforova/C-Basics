﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covertCtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double farenh = celsius * 1.8 + 32;

            Console.WriteLine(Math.Round(farenh,2));
        }
    }
}
