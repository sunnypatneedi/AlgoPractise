using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class DuplicateChars
    {
        //JUST A SHOWCASE SOLUTION FOR PRACTISE
        //Input - "Hello, World"
        //Output - "Helo, wrd"

        //using dictionary or hashtable
        public static string RemoveDuplicates(string s)
        {
            Dictionary<char, int> nonDuplicate = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!nonDuplicate.ContainsKey(c)) nonDuplicate.Add(c, 1);
            }
            return new string(nonDuplicate.Keys.ToArray());
        }

    }
}
