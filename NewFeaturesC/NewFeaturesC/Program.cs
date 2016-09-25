using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace NewFeaturesC
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointInstance1 = new Point(10, 6);
            var pointInstance2 = new Point(10, 10);
            var pointInstance3 = new Point(-5, 5);
            Point instance4 = null;
           WriteLine(Point.ToJson(null));
           WriteLine(Point.ToJson(new Point[] { pointInstance1, pointInstance2, pointInstance3,instance4 }));

            WriteLine(pointInstance1.Sum());

       }
    }
}
