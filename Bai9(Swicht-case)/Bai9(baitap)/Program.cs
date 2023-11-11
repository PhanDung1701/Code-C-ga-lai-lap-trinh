using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_baitap_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luachon;
            Console.WriteLine("CHƯƠNG TRÌNG TÌM KIẾM!");
            Console.WriteLine("1.Tìm theo tên");
            Console.WriteLine("2.Tìm theo tac giả");
            Console.WriteLine("3.TÌm theo NXB");
            Console.WriteLine("4.Tìm thoe tiêu đề");
            Console.WriteLine("Lựa chọn: ");
            luachon=int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    Console.WriteLine("TÌm thoe tên");
                    break;
                case 2:
                    Console.WriteLine("Tìm thoe tác giả");
                    break;
                case 3:
                    Console.WriteLine("Tìm theo NXb");
                    break;
                case 4:
                    Console.WriteLine("tìm theo tiêu đề");
                    break;
                default:
                    Console.WriteLine("Phím bấm không hợp lệ");
                    break;
            }    
            Console.ReadKey();
        }
    }
}
