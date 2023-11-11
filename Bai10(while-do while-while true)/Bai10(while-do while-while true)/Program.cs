using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_while_do_while_while_true_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập n: ");
            n=int.Parse(Console.ReadLine());

            while (n<1 || n>99)
            {
                Console.WriteLine("Nhập lại đê anh bạn!");
                n=int.Parse(Console.ReadLine()) ;
            }
            Console.WriteLine("Đa nhập xong n , n=" + n);
            Console.ReadKey();
        }
        
    }
}
