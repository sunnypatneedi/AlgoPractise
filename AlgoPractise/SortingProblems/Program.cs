using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {3,8,2};
            Console.WriteLine("<<<<< OUTPUT "+ MergeSort.Sort(input, 0, input.Length-1).ToString());
            Console.ReadLine();
        }
    }
}
