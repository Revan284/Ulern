using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool err = false;
            var rand = new Random((int)DateTime.Now.Millisecond);
            for (int i = 0; i < 1000; i++)
            {
                int a = rand.Next(100, 1000);
                var actual = Expr2_Task.Reverse(a);
                var expect = Reversion(a);
                if (actual != expect)
                {
                    Console.WriteLine("Error For Number: {0}", a);
                    Console.WriteLine("Actual : {0}", actual);
                    Console.WriteLine("Expect : {0}", expect);
                    err = true;
                    break;
                }
                if (i % 100 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Выполнено {0}%", i / 10);
                }
            }
            if (err == false)
            {
                Console.Clear();
                Console.WriteLine("Все тесты пройдены. Задание выполнено!");
            }
            Console.ReadKey();
        }
        static int Reversion(int a) => int.Parse(string.Concat(a.ToString().Reverse().ToArray()));
    }
}
