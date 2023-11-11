using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("Nhap vao gia tri x: ");
            x= float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia tri y: ");
            y= float.Parse(Console.ReadLine());
            float t = x + y;
            float t2 = x - y;
            float t3 = x * y;
            float t4= x / y;
            Console.WriteLine("Tong 2 so {0} va {1} la {2}", x, y, t);
            Console.WriteLine("Tong 2 so {0} va {1} la {2}", x, y, t2);
            Console.WriteLine("Tong 2 so {0} va {1} la {2}", x, y, t3);
            Console.WriteLine("Tong 2 so {0} va {1} la {2}", x, y, t4);
            Console.ReadKey();
        }
    }
}
