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
            //REMOVE DUPLICATE CHARS
            Console.WriteLine("Enter a string below:");
            string input = Console.ReadLine();
            Console.WriteLine("OUTPUT without duplicates >>>>>>: " +DuplicateChars.RemoveDuplicates(input));
            Console.ReadLine();     
            
            
            /*
            //IS PLAINDROME
            Console.WriteLine("Enter a palindrome below:");
            string input = Console.ReadLine();
            Console.WriteLine("OUTPUT >>>>>>: " + Palindrome.IsPalindrome(input));
            Console.ReadLine();     
            */

            /*
            //STRING TO INT (ATOI)
            Console.WriteLine("Enter a number below:");
            string input = Console.ReadLine();
            Console.WriteLine("OUTPUT >>>>>>: " + Atoi.StringToInt(input));
            Console.ReadLine();            
            */

            //REVERSE STRING
            /*
            while (Console.ReadLine()!="q")
            {
                Console.WriteLine("Enter INPUT: ");
                string input = Console.ReadLine();
                Console.WriteLine("OUTPUT >>>>>>: " + ReverseString.ReverseStringInPlace(input.ToCharArray()));
                Console.WriteLine("(Type 'q' to quit OR hit Enter to continue.)");
            }
            */
        }
    }
}
