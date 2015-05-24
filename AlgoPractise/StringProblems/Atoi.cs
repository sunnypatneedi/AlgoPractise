using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class Atoi
    {
        public static int StringToInt(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            bool isNegative = false;
            if (s[0] == '-') isNegative = true;

            int result = 0;
            for (int i = s[0] == '-' ? 1 : 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    //removing '0', to handle the overflow char
                    result = result * 10 + (s[i] - '0');
                }
            }

            return isNegative ? -result : result;
        }
    }
}
