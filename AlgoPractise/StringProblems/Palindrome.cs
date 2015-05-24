using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            //Is empty string palindrome?
            if (String.IsNullOrEmpty(s)) return false;
            //Can we assume input doesn't include special chars, white spaces and lower case? 
            StringBuilder builder = new StringBuilder(RemoveWhitespaces(s.ToLower()));

            int end = builder.Length - 1;
            //no need to traverse the whole string, just half is sufficient
            for (int start = 0; start < end/2; start++)
            {
                if (builder[start] != builder[end])
                {
                    return false;
                }
                end--;
            }
            return true;
        }

        public static string RemoveWhitespaces(string str)
        {
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", "");
            return str;
        }

    }
}
