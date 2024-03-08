using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "madam";
            string output = string.Empty;

            for (int i = input.Length -1; i >=0; i--)
            {
                output += input[i];
            }

            if(string.Equals(input,output))
            {
                Console.WriteLine("Given string is a Palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not a Palindrome");
            }
            
            Console.ReadLine();

        }
    }
}
