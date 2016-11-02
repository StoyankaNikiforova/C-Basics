using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";

            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTimeOffset result = DateTimeOffset.ParseExact(dateString, format, provider);
            Console.WriteLine( result.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
