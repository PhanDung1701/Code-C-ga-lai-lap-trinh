using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_Swicht_case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập a: ");
            a=int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine("Số {0} là số chẵn",a); break;
                default: Console.WriteLine("Số {0} là số lẻ", a); break;
            }
            Console.ReadKey();
        }
    }
}
