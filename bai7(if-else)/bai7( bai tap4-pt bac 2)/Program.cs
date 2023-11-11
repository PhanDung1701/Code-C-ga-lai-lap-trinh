using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7__bai_tap4_pt_bac_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b, c, delta;
            Console.WriteLine("Nhập a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            c = float.Parse(Console.ReadLine());
            delta=(b*b)-(4*a*c);
            if(delta<0)
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
            else if(delta==0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép là {0} ", x);
            }
            else
            {
                double x1= (-b+Math.Sqrt(delta))/(2*a);
                double x2= (-b-Math.Sqrt(delta))/(2*a);
                Console.WriteLine("Phương trình có hai nghiệm phân biệt");
                Console.WriteLine("X1={0}", x1);
                Console.WriteLine("X2={0}", x2);
            }
            Console.ReadKey();
        }
    }
}
