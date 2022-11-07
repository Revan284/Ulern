using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        internal static int x;
        internal static int y;

        static void Main(string[] args)
        {
            int[] a = new int[13] { 0x6d, 0x65, 0x0a, 0x2b, 0x62, 0x0a, 0x3d, 0x2d, 0x3b, 0x61, 0x3d, 0x3b, 0x0a};
            int[] b = new int[13] { 0x4f, 0x62, 0x6d, 0x61, 0x3d, 0x3b, 0x62, 0x61, 0x62, 0x0a, 0x2d, 0x62, 0x0a};
            for (int i = 0; i < 5; i++)
            {
                x = a[i];
                y = b[i];
                Expr1_Task.Exchange(x, y);
            }
            Console.ReadKey();
        }
    }
}
