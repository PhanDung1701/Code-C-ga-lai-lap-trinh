using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_bai_tap_2_tinh_BMI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            int n;
            Console.Write("NHap chieu cao: ");
            c=int.Parse(Console.ReadLine());
            Console.Write("Nhap can nang: ");
            n=int.Parse(Console.ReadLine());

            double BMI=c/n*n;
            if (BMI < 15)
            {
                Console.WriteLine("Ban qua gay");
            }
            else if (BMI >= 15 && BMI < 16)
            {
                Console.WriteLine("Ban gay");
            }
            else if (BMI >= 16 && BMI < 18.5)
            {
                Console.WriteLine("Ban hoi gay");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Ban binh thuong");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Ban hoi beo");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Ban beo");
            }
            else
            {
                Console.WriteLine("Ban qua beo");
            }
            Console.ReadKey();
        }
    }
}
