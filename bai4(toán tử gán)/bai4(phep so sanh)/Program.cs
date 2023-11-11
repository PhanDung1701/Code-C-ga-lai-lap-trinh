using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_phep_so_sanh_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so nguyen n: ");
            n= int.Parse(Console.ReadLine());
            Console.WriteLine("Ba vua nhap vao so {0}", n);
            if (n %2== 0)
            {
                Console.WriteLine("So {0} la so chan",n);
            }
            else
            {
                Console.WriteLine("So {0} la so le", n);
            }

        }
    }
}
