using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_nhi_phan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            Console.Write(" n = ");

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[(0)] = ", 1);

                a[i] = int.Parse(Console.ReadLine());
            }
            string fileName = "Dulieu.dat";

            BinaryWriter wr = new BinaryWriter(new FileStream(fileName, FileMode.Create));

            for (int i = 0; i < n; i++)
                wr.Write(a[i]);
            wr.Close();
            BinaryReader rd = new BinaryReader(new FileStream(fileName, FileMode.Open)); 
            while (rd.BaseStream.Position != rd.BaseStream.Length)
            {
                Console.WriteLine(rd.ReadInt32());
            }
            rd.Close();
            Console.ReadLine();
        }
    }
}
