using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_toan_tu_3_ngoi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào so nguyên n: ");
            n=int.Parse(Console.ReadLine());
            string traloi = (n % 2 == 0) ? "Chẵn" : "Lẻ";
            Console.WriteLine(traloi);
            Console.ReadKey();
        }
    }
}
