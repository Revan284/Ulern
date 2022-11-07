using System;

namespace ConsoleApp1
{
    class Expr1_Task
    {
        internal static void Exchange(int a, int b)
        {
            // ваш код
            var surname = "Пупкин";
            var name = "Иван";
            Console.WriteLine($"Ваше Имя - {surname}. Ваша Фамилия - {name}");

            (surname,name) = (name,surname);
            Console.WriteLine($"Ваше Имя - {surname}. Ваша Фамилия - {name}");

            if ((a == Program.y) & (b == Program.x))
                Console.Write("{0}{1}", ((char)a), ((char)b));
        }
    }
}
