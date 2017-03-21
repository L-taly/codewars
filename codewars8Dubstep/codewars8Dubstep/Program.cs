using System;

namespace codewars8Dubstep
{
    class Program
    {
        public static string SongDecoder(string input)
        {
            // Your code...
            return System.Text.RegularExpressions.Regex.Replace(input.Replace("WUB", " ").Trim(' '), @" +", " ");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}