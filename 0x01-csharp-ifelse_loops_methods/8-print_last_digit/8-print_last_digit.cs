using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)        
        {
            int r = Math.Abs(number) % 10;
            Console.Write(r);
        }
    }
}