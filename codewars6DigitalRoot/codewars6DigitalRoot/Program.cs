using System;

namespace codewars6DigitalRoot
{
    class Program
    {
        public int DigitalRoot(long n)
        {
            // Your awesome code here!
            for (; n > 10;)
            {
                n = n / 10 + n % 10;
            }
            return (int)n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}