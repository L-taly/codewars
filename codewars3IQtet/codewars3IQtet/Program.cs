using System;

namespace codewars3IQtet
{
    class Program
    {
        public static int Test(string numbers)
        {
            //Your code is here...
            int odd = 0;
            int even = 0;
            string[] num = numbers.Split(' ');
            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i]) % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                if (even == 1 && odd > 1)
                {
                    if (int.Parse(num[i]) % 2 == 0)
                    {
                        return i + 1;
                    }
                    else if (int.Parse(num[i - 1]) % 2 == 1)
                    {
                        return i - 1;
                    }
                    return i;
                }
                if (odd == 1 && even > 1)
                {
                    if (int.Parse(num[i]) % 2 == 1)
                    {
                        return i + 1;
                    }
                    else if (int.Parse(num[i - 1]) % 2 == 0)
                    {
                        return i - 1;
                    }
                    return i;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}