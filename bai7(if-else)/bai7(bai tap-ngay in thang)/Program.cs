using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_bai_tap_ngay_in_thang_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang,nam;
            Console.WriteLine("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 10 || thang == 11 || thang == 12)
            {
                Console.WriteLine("Thang {0} co 31 ngay!", thang);

            }
            else if (thang == 4 || thang == 6 || thang==9 || thang==11)
            {
                Console.WriteLine("Thang {0} co 30 ngay",thang);
            }
            else if(thang==2)
            {
                Console.WriteLine("Nhap vao nam: ");
                nam= int.Parse(Console.ReadLine());
                if ((nam % 4 == 0) && (nam % 100 != 0) || (nam % 400 == 0))
                {
                    Console.WriteLine("Nam {0} la nam nhuan, nen thang {1} co 29 ngay", nam, thang);
                }
                else { Console.WriteLine("Nam {0} la nam khong nhuan, nen thang {1} co 28 ngay", nam, thang); }
                Console.ReadKey();

            }
        }
    }
}
