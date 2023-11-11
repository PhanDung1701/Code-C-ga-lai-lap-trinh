using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_bai_tap2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r;
            Console.Write("Nhap vao ban kinh: ");
            r= float.Parse(Console.ReadLine());
            double c = 2 * r * 3.14;
            double s = 3.14 * (r * r);
            Console.WriteLine("Chu vi hinh tron la: "+c);
            Console.WriteLine("Dien tich hinh tron la: "+s);
            Console.ReadKey();
        }
    }
}
