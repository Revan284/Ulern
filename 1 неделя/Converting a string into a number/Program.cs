using System;
using System.Globalization;

namespace Converting_a_string_into_a_number
{
    internal class Program
    {
        public static void Main()
        {
            string doubleNumber = "894376.243643";
            //int number = doubleNumber; Вася уверен, что ошибка где-то тут
            double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture);
            Console.WriteLine(number + 1);
            Console.ReadKey();
        }
    }
}
