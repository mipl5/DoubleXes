using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleX dx = new DoubleX();
            dx.SetS("Help");
            dx.SetD(5);
            Console.WriteLine("{0} - {1}", dx.GetS(), dx.GetD());
            Console.WriteLine(dx);
        }
    }
}
