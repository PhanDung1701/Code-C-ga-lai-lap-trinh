using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_For_each_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.WriteLine("Nhap 1 thang: ");
            thang = int.Parse(Console.ReadLine());
            int[] lst = { 1, 3, 5, 8, 10, 12 };
            int[] lst1 = { 4, 6, 7, 9, 11 };
            foreach (int i in lst)
            {
                if(thang==i)
                {
                    Console.WriteLine("Thang {0} co 31 ngay",i);
                }
            }
            foreach (int j in lst1)
            {
                if (thang==j)
                {
                    Console.WriteLine("Thang {0} co 30 ngay",j);
                }
            }
            Console.ReadLine();
        }
    }
}
