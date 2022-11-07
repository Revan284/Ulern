using System;

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
