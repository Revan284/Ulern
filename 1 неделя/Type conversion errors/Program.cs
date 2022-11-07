using System;

namespace Type_conversion_errors
{
    internal class Program
    {
        public static void Main()
        {
            //double pi = Math.PI;
            //int tenThousand = 10000L;
            //float tenThousandPi = pi * tenThousand;
            //int roundedTenThousandPi = tenThousandPi;
            //int integerPartOfTenThousandPi = tenThousandPi;

            double pi = Math.PI;
            long tenThousand = 10000L;
            double tenThousandPi = pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;

            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
            Console.ReadKey();
        }
    }
}
