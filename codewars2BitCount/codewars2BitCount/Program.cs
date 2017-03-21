using System;

namespace codewars2BitCount
{
    class Program
    {
        public static int CountBits(int n)
        {
            int count = 0;
            for (; n != 0;)
            {
                if (n % 2 == 1)
                {
                    count++;
                }
                n = n / 2;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}