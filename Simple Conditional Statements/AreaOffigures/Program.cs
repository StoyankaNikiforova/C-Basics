using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOffigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    area = calculateSquareArea(a);
                    break;
                case "rectangle":
                    double firstSide = double.Parse(Console.ReadLine());
                    double secondSideb = double.Parse(Console.ReadLine());

                    area = calculateRectangleArea (firstSide, secondSideb);
                    break;
                case "circle":
                    double side = double.Parse(Console.ReadLine());
                    area = calculateCircleArea(side);
                    break;
                case "triangle":
                    double sideTr = double.Parse(Console.ReadLine());
                    double sideH = double.Parse(Console.ReadLine());

                    area = calculateTriangleArea(sideTr, sideH);
                    break;

            }
            Console.WriteLine("{0:f3}", area);
        }

        static double calculateSquareArea(double a)
        {
            return a * a;
        }

        static double calculateRectangleArea(double a, double b)
        {
            return a * b;
        }
        static double calculateCircleArea(double a)
        {
            return Math.PI*(a * a);
        }
        static double calculateTriangleArea(double a, double h)
        {
            return (a * h)/2;
        }
    }
}
