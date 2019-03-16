using System;

namespace Factorial
{
    class MainClass
    {
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number greater than or equal to zero: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of " + n + " is " + Factorial(n));
        }
    }
}
