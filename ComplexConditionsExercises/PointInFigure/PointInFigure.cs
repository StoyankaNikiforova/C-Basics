using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class PointInFigure
    {
        static void Main()
        {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if ((y == 0 && x > 0 && x < 3* h) || (y == h && x > 0 && x < h) || (y == h && x > 2 * h && x < 3 * h) 
            || (y == 4 * h && x > h && x < 2 * h) || (x == 0 && y > 0 && y < h) || (x == h && y > h && y < 4 * h)
            || (x == 2 * h && y > h && y < 4 * h) || (x == 3*h && y > 0 && y < h))
        {
            Console.WriteLine("border");
        }

        if ((y < h) && (y > 0))
        { 
            if ((x > 0) && (x < 3 * h))
            {
                Console.WriteLine("inside");
            }
            else if ((x < 0) || (x > 3 * h))
            {
                Console.WriteLine("outside");
            }
            
        }        
        else if((y > h) && (y < 4 * h))
        {
            if ((x > h) && (x < 2 * h))
            {
                Console.WriteLine("inside");
            }
            else if ((x < h) || (x > 2 * h))
            {
                Console.WriteLine("outside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }


    }
}

