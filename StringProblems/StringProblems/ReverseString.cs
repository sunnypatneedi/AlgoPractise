//JUST A SHOWCASE SOLUTION FOR PRACTISE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class ReverseString
    {
        //Input - Hello, sunny, yes
        //Output - 0lleH, ynnus, sey

        //In-place reversal
        //doesn't consume auxiliary memory but limits usages of the method
        public static string ReverseStringInPlace(char[] chars)
        {
            if (chars.Length == 0) return String.Empty;
            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
                j--;
            }
            return new string(chars);
        }
        //New String 
        public static string ReverseStringWithNewString(string str)
        {
            if (string.IsNullOrEmpty(str)) return String.Empty;
            char[] chars = str.ToCharArray();
            int j = str.Length - 1;
            for (int i = 0; i < str.Length / 2; i++)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
                j--;
            }
            return new string(chars);
        }
    }
}
