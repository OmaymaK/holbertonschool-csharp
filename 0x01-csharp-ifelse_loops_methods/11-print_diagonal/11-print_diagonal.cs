using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine();
            }
            for (int i = 1; i < length + 1; i++)
            {
                Console.WriteLine("\\");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
