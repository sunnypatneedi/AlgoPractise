using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (Console.ReadLine()!="q")
            {
                Console.WriteLine("Enter INPUT: ");
                string input = Console.ReadLine();
                Console.WriteLine("OUTPUT >>>>>>: " + ReverseString.ReverseStringInPlace(input.ToCharArray()));
                Console.WriteLine("(Type 'q' to quit OR hit Enter to continue.)");
            }   
        }
    }
}
