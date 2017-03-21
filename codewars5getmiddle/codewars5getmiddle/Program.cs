using System;

namespace codewars5getmiddle
{
    class Program
    {
        public static string GetMiddle(string s)
        {
            //Code goes here!
            return s.Substring((s.Length - 1) / 2, 2 - (s.Length % 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}