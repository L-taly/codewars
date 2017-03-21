using System;
using System.Linq;
namespace codewars2BitCount
{
    class Program
    {
        //1
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
        //2
        public static int CountBits2(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}