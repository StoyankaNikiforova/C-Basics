using System;
  class MetricConvertor
    {
        static void Main(string[] args)
        {
         double number = double.Parse(Console.ReadLine());
        string inputMert = Console.ReadLine();
        string output = Console.ReadLine();        

        if (inputMert != "m")
        {
            switch (inputMert)
            {
                case "mm":
                    number = number / 1000;
                    break;
                case "cm":
                    number = number / 100;
                    break;
                case "mi":
                    number = number / 0.000621371192;
                    break;
                case "km":
                    number = number / 0.001;
                    break;
                case "in":
                    number = number / 39.3700787;
                    break;
                case "ft":
                    number = number / 3.2808399;
                    break;
                case "yd":
                    number = number / 1.0936133;
                    break;

            }
        }

        double outputNumber = number;

        if (output != "m")
        {
            switch (output)
            {
                case "mm":
                    outputNumber = outputNumber * 1000;
                    break;         
                case "cm":
                    outputNumber = outputNumber * 100;
                    break;          
                case "mi":
                    outputNumber = outputNumber * 0.000621371192;
                    break;          
                case "km":
                    outputNumber = outputNumber * 0.001;
                    break;          
                case "in":
                    outputNumber = outputNumber * 39.3700787;
                    break;          
                case "ft":
                    outputNumber = outputNumber * 3.2808399;
                    break;          
                case "yd":
                    outputNumber = outputNumber * 1.0936133;
                    break;          

            }
        }
        Console.WriteLine(outputNumber + " " + output);

    }
    }

