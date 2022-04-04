using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Comparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4, length1, length2;
            x1 = 9;
            y1 = 12;
            x2 = 6;
            y2 = 15;
            x3 = 6;
            y3 = 2;
            x4 = 9;
            y4 = 0;
            length1 = Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            length2 = Math.Sqrt(Math.Abs((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3)));
            Console.WriteLine("length of first line is:{0} and second line is:{1}", length1, length2);
            //  java oops concept of Equals Method 
            Console.WriteLine(length1.Equals(length2));
            // java oops concept of CompareTo Method
            Console.WriteLine(length1.CompareTo(length2));
            Console.ReadLine();

        }
    }
}
