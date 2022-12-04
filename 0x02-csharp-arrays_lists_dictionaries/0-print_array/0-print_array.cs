﻿using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
            {
                Console.WriteLine();
                return new int[size];
            }
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
                arr[size - 1] = size - 1;
                Console.WriteLine($"{arr[size - 1]}");
                return arr;
            }
        }
    }
}
