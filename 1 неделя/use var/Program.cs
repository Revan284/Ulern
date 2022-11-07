using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_var
{
    internal class Program
    {
        static public void Main()
        {
            // var a = 5;  ← исправьте эту строку
            var a = 5.0;
            a += 0.5;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
