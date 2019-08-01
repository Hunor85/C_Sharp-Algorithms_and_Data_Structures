using System;

namespace Find_the_nth_of_a_number
{
    class MainClass
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;
            return x * Power(x, n - 1);
        }

        public static void Main(string[] args)
        {
            double x;
            int n;

            Console.Write("Enter values for x and n: ");

            x = Convert.ToDouble(Console.ReadLine());

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + "^" + n + "=" + Power(x, n));
        }
    }
}
