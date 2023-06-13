using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            ChildClass c = new ChildClass("mts", 2, 2, true);
            c.TarifInfo();
            double a = c.Qp();
            Console.WriteLine(a);
        }
    }
}
