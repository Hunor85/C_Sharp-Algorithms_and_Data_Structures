using System;

namespace Print_Numbers_From_1_to_n
{
    class MainClass
    {
        public static void Print1(int n)
        {
            if (n == 0)
                return;
            Console.Write(n + " ");
            Print1(n-1);
        }

        public static void Print2(int n)
        {
            if (n == 0)
                return;
            Print2(n - 1);
            Console.Write(n + " ");
        }


        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Print1(n);
            Console.WriteLine();

            Print2(n);
            Console.WriteLine();

        }
    }
}
