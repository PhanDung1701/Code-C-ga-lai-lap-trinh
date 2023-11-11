using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_bài_tập_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;

            double d1 = 2.0;
            double d2 = 5.0;
            double d3 = -0.5;

            int a=i1+(i2*i3);
            int b=i1*(i2+i3);
            int c=i1/(i2+i3);
            int d=i1/(i2+i3);

            Console.WriteLine("{0} + ({1}*{2}) la:{3}",i1,i2,i3,a);
            Console.WriteLine("{0} * ({1}+{2}) la:{3}", i1, i2, i3,b);
            Console.WriteLine("{0} / ({1}+{2}) la:{3}", i1, i2, i3,c);
            Console.WriteLine("{0} / {1}+{2} la:{3}", i1, i2, i3,d);
            Console.ReadKey();
        }
    }
}
