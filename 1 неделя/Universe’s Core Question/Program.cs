using System;

namespace Universe_s_Core_Question
{
    internal class Program
    {
        public static void Main()
        {
            Print(GetSquare(42));
            Console.ReadKey();
        }

        static double GetSquare(double userNumber)
        {
            return userNumber * userNumber;
        }

        static void Print(double sqareUserNumber)
        {
            Console.WriteLine(sqareUserNumber);
        }
    }
}
