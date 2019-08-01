using System;

namespace Sum_of_digits_of_an_integer
{
    class MainClass
    {
        public static int SumDigits(int n)
        {
            if (n / 10 == 0)
                return n;
            return SumDigits(n / 10) + n % 10;
        }

        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(n));
        }
    }
}
