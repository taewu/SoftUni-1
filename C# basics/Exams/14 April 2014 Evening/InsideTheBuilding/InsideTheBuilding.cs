﻿using System;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        if (x1>=0 && x1<=3*h)
        {
            if ((x1<=h || x1>=2*h) && (y1>=0 && y1<=h))
            {
                Console.WriteLine("inside");
            }
            else if ((x1>=h && x1<=2*h) && (y1>=0 && y1<=4*h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }
           
        if (x2 >= 0 && x2 <= 3 * h)
        {
            if ((x2 <= h || x2 >= 2 * h) && (y2 >= 0 && y2 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x2 >= h && x2 <= 2 * h) && (y2 >= 0 && y2 <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }
           
        if (x3 >= 0 && x3 <= 3 * h)
        {
            if ((x3 <= h || x3 >= 2 * h) && (y3 >= 0 && y3 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x3 >= h && x3 <= 2 * h) && (y3 >= 0 && y3 <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }
           
        if (x4 >= 0 && x4 <= 3 * h)
        {
            if ((x4 <= h || x4 >= 2 * h) && (y4 >= 0 && y4 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x4 >= h && x4 <= 2 * h) && (y4 >= 0 && y4 <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
        else
        {
            Console.WriteLine("outside");
        }
           
        if (x5 >= 0 && x5 <= 3 * h)
        {
            if ((x5 <= h || x5 >= 2 * h) && (y5 >= 0 && y5 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x5 >= h && x5 <= 2 * h) && (y5 >= 0 && y5 <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
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

//ALTERNATIVE SOLUTION

//    int h = int.Parse(Console.ReadLine());
//    int[] coordX = new int[5];
//    int[] coordY = new int[5];

//    for (int i = 0; i < 5; i++)
//    {
//        coordX[i] = int.Parse(Console.ReadLine());
//        coordY[i] = int.Parse(Console.ReadLine());
//    }

//    for (int i = 0; i < 5; i++)
//    {
//        if ((coordY[i] <= h) && (coordX[i] <= 3*h) && (coordX[i] >= 0) && (coordY[i] >= 0))
//        {
//            Console.WriteLine("inside");
//        }
//        else if ((coordY[i] >= h) && (coordY[i] <= 4*h) && (coordX[i] >= h) && (coordX[i] <= 2*h))
//        {
//            Console.WriteLine("inside");
//        }
//        else
//        {
//            Console.WriteLine("outside");
//        }
//     }

