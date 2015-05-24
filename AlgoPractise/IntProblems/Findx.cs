using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntProblems
{
    class Findx
    {
        public static int FindIntInSortedArray(int[] n, int x, int start, int end)
        {
            Console.WriteLine("start: " + start + "mid: " + (start + end) / 2 + "end: " + end);
            if (n.Length == 0) return 0;
            if (n[0]==x) return n[0];
            
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (n[mid] == x) return n[mid];
                else if (n[mid] > x) end = mid - 1;
                else if (n[mid] < x) start = mid + 1;
            }
            return 0;
        }
    }
}
