using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    internal static class Extensions
    {
        public static bool customContains(this string word, string searched)
        {
            searched = searched.ToLower();
            int i = 0;
            foreach (char c in word.ToLower())
            {
                if (i != searched.Length)
                {
                    if (c == searched[i])
                    {
                        i++;
                    }
                }
                else if (c == searched[i])
                {
                    i = 0;
                }
                break;
            }
            if (i == searched.Length)
            {
                return true;

            }
            return false;
        }
    }
}
