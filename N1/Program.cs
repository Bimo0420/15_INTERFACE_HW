using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgress arith = new ArithProgress();
            arith.SetStart(0);
            arith.SetStep(2);
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            arith.Reset();
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            GeomProgress geom = new GeomProgress();
            geom.SetStart(2);
            geom.SetStep(2);
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            geom.Reset();
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.ReadKey();
        }
    }
}
