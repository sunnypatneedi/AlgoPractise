using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntProblems
{
    class ReturnLargestConcatInt
    {
        //Clarifications
        //1) repeated numbers in input?
        //2) sorted/unsorted?
        //3) 
        //input = {1,4,34,9,5};
        //output should be 954341

        public static string ReturnLargerInt(string x, string y)
        {
            StringBuilder xy = new StringBuilder(x);
            xy.Append(y);

            StringBuilder yx = new StringBuilder(y);
            yx.Append(x);

            Console.WriteLine("<<<<<< XY " + xy + " vs YX " + yx + " >>>>>>");
            return xy.ToString();
        }

        public static string CompareInts(int[] n)
        {
            StringBuilder output = new StringBuilder(n.Length);
            for (int i = 0; i < n.Length - 1; i++)
            {
                output.Append(ReturnLargerInt(n[i].ToString(), n[i + 1].ToString()));
            }
            Console.WriteLine("<<<<<<OUTPUT>>>>>>");
            Console.WriteLine(output);
            Console.ReadLine();
            return string.Empty;
        }
    }
}
