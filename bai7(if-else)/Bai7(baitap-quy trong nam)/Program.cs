using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_baitap_quy_trong_nam_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            if(thang == 1 || thang ==2 || thang==3)
            {
                Console.WriteLine("Tháng {0} là quý 1!",thang);
            }
            else if(thang ==4 || thang ==5 || thang ==6)
            {
                Console.WriteLine("Tháng {0} là quý 2!",thang);
            }
            else if(thang==7 || thang ==8 || thang ==9)
            {
                Console.WriteLine("Tháng {0} là quý 3!",thang);
            }
            else
            {
                Console.WriteLine("Tháng {0} là quý 4!", thang);
            }

        }
    }
}
