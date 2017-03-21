using System;

namespace codewars9CreditCardMask
{
    class Program
    {
        public static string Maskify(string cc)
        {
            string bb = "";
            if (cc.Length > 4)
            {
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    bb += '#';
                }
                bb += cc.Substring(cc.Length - 4, 4);
                return bb;
            }
            else
            {
                return cc;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}