using System;

namespace codewars1sum
{
    class Program
    {
        public static string seriesSum(int n)
        {
            // Happy Coding ^_^
            float sum = 0;
            int m = 1;
            for (int i = 0; i < n; i++)
            {
                sum += (float)1 / (float)m;
                m += 3;
            }
            string sums = String.Format("{0:N2}", sum);
            return sums;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}