using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();

            Regex regex = new Regex(@"s3cr3t!P@ssw0rd");
            Match match = regex.Match(inputPass);
            if (match.Success)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
