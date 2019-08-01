using System;

namespace Fibanocci
{
    class MainClass
    {
        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= terms; i++)
                Console.Write(Fib(i) + " ");
        }
    }
}
