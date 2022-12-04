using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
                Console.WriteLine();
            else if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else 
            {
                int[] arr = new int[size];
                for (int i = 0; i < size - 1; i++)
                {
                    arr[i] = i;
                    Console.Write($"{arr[i]} ");
                }
                Console.Write($"{arr[size]}");
            }
        }
    }
}
