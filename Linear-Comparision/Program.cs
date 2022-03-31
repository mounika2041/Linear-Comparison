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
            double x1,y1,x2,y2,x3,y3,x4,y4,length1,length2;
            x1 = 2;
            y1 = 6;
            x2 = 4;
            y2 = 9;
            x3 = 6;
            y3 = 3;
            x4 = 8;
            y4 = 7;
            length1 = Math.Sqrt(Math.Abs((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)));
            length2 = Math.Sqrt(Math.Abs((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3)));
            Console.WriteLine("length of first line is:{0} and second line is:{1}", length1,length2);
            if (length1 == length2)
                Console.WriteLine("Two lines are equal");
            else
                Console.WriteLine("Two lines are not equal");
            Console.ReadLine();
        }
    }
}
