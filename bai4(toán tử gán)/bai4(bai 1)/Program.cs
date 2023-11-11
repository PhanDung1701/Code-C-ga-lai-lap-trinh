using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_bai_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Nhap so a: ");
            a=int.Parse(Console.ReadLine());
            a += 3;
            Console.WriteLine(a);
            a -= 5;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 9;
            Console.WriteLine(a);
            a %= 5;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
