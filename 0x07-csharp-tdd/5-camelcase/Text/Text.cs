﻿using System;

namespace Text
{
    /// <summary>
    /// number of word
    /// </summary>
    public class Str
    {
        /// <summary>
        /// number of word uysing Camel Case
        /// </summary>
        /// <param name="s"> String to check</param>
        /// <returns> numberof word</returns>
        public static int CamelCase(string s)
        {
            if (s == null)
            {
                return 0;
            }
            if (s.Length == 0)
            {
                return 0;
            }
            string[] list = s.Split(' ');
            int i = 0;
            int n = 0;
            if (list.Length >= 1 && !Char.IsUpper(s[0]) && s[0] != ' ')
            {
                n = 1;
            }
            foreach (var str in list)
            {
                try
                {
                    foreach (var ch in str)
                    {
                        if (char.IsUpper(ch))
                            n += 1;
                    }
                }
                catch
                {
                    continue;
                }
                i += 1;
            }
            return n;
        }
    }
}