using System;

namespace Euclids_algorithm
{
    class MainClass
    {
        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;

            return GCD(b, a % b);
        }

        public static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter values for a and b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GCD of " + a + " and " + b + " is " + GCD(a,b));
        }
    }
}
