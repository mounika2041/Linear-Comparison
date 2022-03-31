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
            double x1,y1,x2,y2,length;
            x1 = 2;
            y1 = 3;
            x2 = 4;
            y2 = 5;
            length = Math.Sqrt(Math.Abs((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)));
            Console.WriteLine("length of two points is:{0}",length);
            Console.ReadLine();
        }
    }
}
