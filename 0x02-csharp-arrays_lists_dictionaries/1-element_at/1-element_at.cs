using System;

namespace _1_element_at
{
    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            if (index > array.Length)
            {
                Console.WriteLine("Index out of range");
                return -1;
            }
            else
            {
                return array[index];
            }
        }
    }
}
