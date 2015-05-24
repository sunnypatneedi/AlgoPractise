using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    class MergeSort
    {
        public static int[] Sort(int[] input, int start, int end)
        {
            if (input.Length < 2) return input;
            int mid = input.Length/2;
            int[] firstHalf = Sort(input, start, mid - 1);
            int[] secondHalf = Sort(input, mid, end);

            return Merge(firstHalf, secondHalf); 
        }

        public static int[] Merge(int[] input1, int[] input2)
        {
            int[] output = {};
            int index = 0;
            for(int i = 0; i< input1.Length; i++){
                output[i] = input1[i];
                index=i;
            }
            for(int j=0; j<input2.Length; j++){
                output[index++] = input2[j];
            }
            return output;
        }
    }
}
