﻿using System;


namespace Invalid_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //... num1 = +5.5e-2;
            //... num2 = 7.8f;
            //... num3 = 0;
            //... num4 = 2000000000000L;

            double num1 = +5.5e-2;
            float num2 = 7.8f;
            byte num3 = 0;
            long num4 = 2000000000000L;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            Console.ReadKey();
        }
    }
}
