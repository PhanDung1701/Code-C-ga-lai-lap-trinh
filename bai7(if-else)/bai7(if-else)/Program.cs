using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemtn;
            Console.Write("Nhap diem tot nghiep: ");
            diemtn = float.Parse(Console.ReadLine());
            if(diemtn >= 9.0)
            {
                Console.WriteLine("Ban da dau tot nghiep loai gioi");
            }
            else if(diemtn >=7.0)
            {
                Console.WriteLine("Ban da truot tot nghiep loai kha");
            }
            else if(diemtn >=5)
            {
                Console.WriteLine("Ban tot nghiep loai trung binh");
            }    
            else { Console.WriteLine("Ban da truot tot nghiep"); }
            Console.ReadKey();
        }
    }
}
