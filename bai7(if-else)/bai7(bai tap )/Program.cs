using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_bai_tap__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hieu;
            double tong;
            Console.WriteLine("Nhap vao tong 2 so: ");
            tong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao hieu 2 so: ");
            hieu= Convert.ToDouble(Console.ReadLine());
            double x=(tong+hieu)/2;
            double y = tong - x;
            Console.WriteLine("Gia tri cua x la: " + x);
            Console.WriteLine("Gia tri cua y la: " + y);
            Console.ReadKey();
        }
    }
}
