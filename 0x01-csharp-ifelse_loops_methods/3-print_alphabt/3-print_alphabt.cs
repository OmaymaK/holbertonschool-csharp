﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (i != 'q' && i != 'e')
                {
                    Console.Write(i);
                }
            }
    }
}
}