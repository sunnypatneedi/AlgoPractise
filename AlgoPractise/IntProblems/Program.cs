using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIND LONEST SUB-ARRAY
            List<int> input = new List<int> { 1, 1, 2, 3, 3, 3, 6 };
            Console.WriteLine("RESULT >>> {");
            foreach (int n in LongestSubArray.FindLongestSubArray(input))
            {
                Console.Write(n+" ");
            }
            Console.ReadLine(); 
            /*
            //FIND INT IN SORTED ARRAY
            int[] input = {3,5,30,33,9};
            int[] sortedInput = { 3, 5, 6, 7, 9 };
            Console.WriteLine(Findx.FindIntInSortedArray(sortedInput, 5, 0, sortedInput.Length-1));
            Console.ReadLine(); 
            */
            //Console.WriteLine(ReturnLargestInt.Compare(input));
            //Console.ReadLine(); 
            
            //Console.WriteLine(ReturnLargestConcatInt.CompareInts(input));
            //Console.ReadLine(); 
            
        }
    }
}
