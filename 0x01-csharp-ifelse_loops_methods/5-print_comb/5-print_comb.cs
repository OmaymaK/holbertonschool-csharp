using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string ch = i.ToString("00");
                if (i == 99)
                {
                    Console.Write($"{ch}\r\n");
                }
                else
                {
                    Console.Write($"{ch}, ");
                }
            }
        }
    }
}
