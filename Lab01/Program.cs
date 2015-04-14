using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment seg = new Segment(5, 3, 10, -8);
            seg.print();
            seg.set(10, -8, 5, 3);
            seg.print();
            seg.set(5, 1, 10, 1);
            seg.print();
            seg.set(10, 1, 5, 1);
            seg.print();
            seg.set(1, 1, 1, 10);
            seg.print();

            System.Console.Write("Press ENTER to quit.");
            String tmp=System.Console.ReadLine();

        }
    }
}
