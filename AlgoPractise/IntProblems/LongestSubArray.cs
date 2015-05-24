using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntProblems
{
    class LongestSubArray
    {
        //INPUT - {1,1,2,3,3,3,5,1}
        //OUTPUT - {3,3,3}
        //INPUT - {1,1,2,2}
        //OUTPUT - {1,1}
        //INPUT - {1,2,3}
        //OUTPUT - {1}

        public static List<int> FindLongestSubArray(List<int> inputArray)
        {
            if (inputArray == null) return inputArray;
            if (inputArray.Count == 1) return inputArray;

            int maxCount = 0;
            int currCount = 1;
            List<int> maxSubArray = new List<int>(inputArray.Count);

            for (int i = 1; i < inputArray.Count; i++)
            {
                if (inputArray[i - 1] == inputArray[i])
                {
                    currCount++;
                }

                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    currCount = 1;
                    maxSubArray = new List<int>(maxCount);

                    for (int j = 0; j < maxCount; j++)
                    {
                        maxSubArray.Add(inputArray[i - 1]);
                    }
                }
            }
            return maxSubArray;
        }
    }
}
