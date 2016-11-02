using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine()); ;
            string currencyInput = Console.ReadLine();
            string currencyOutput = Console.ReadLine();

            Dictionary<string, double> currencyColection = new Dictionary<string, double>()
                    {
                        {"USD", 1.79549},
                        {"EUR", 1.95583},
                        {"GBP", 2.53405}
                    };
            double currencyInputInBGN = sum;
            if (currencyInput != "BGN")
            {
                currencyInputInBGN = sum * currencyColection[currencyInput];
            }

            double currencyOutputResult = currencyInputInBGN;
            if (currencyOutput != "BGN")
            {
                        
             currencyOutputResult = currencyInputInBGN /currencyColection[currencyOutput];
                
            }

            Console.WriteLine(Math.Round(currencyOutputResult,2));

        }
    }
}
