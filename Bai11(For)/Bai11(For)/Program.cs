using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_For_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n");
            n=int.Parse(Console.ReadLine());            
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
