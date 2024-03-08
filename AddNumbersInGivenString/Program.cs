using System;
using System.Text.RegularExpressions;

namespace AddNumbersInGivenString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "23asdf2aa29aaa2";
            Console.WriteLine(FindSumOfNumbersInString(input));
            Console.WriteLine(GetSumNumbersInString(input));
            Console.ReadLine();
        }

        static int FindSumOfNumbersInString(string data)
        {
            int sum = 0;
            string number = "";

            foreach (char c in data)
            {
                if (Char.IsNumber(c))
                {
                    number += c;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(number))
                    {
                        sum = sum + Convert.ToInt32(number);
                        number = "";
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(number))
            {
                sum = sum + Convert.ToInt32(number);
            }

            return sum;
        }

        static int GetSumNumbersInString(string input)
        {
            // Use regular expression to find all numbers in the string
            MatchCollection matches = Regex.Matches(input, @"\d+");

            int sum = 0;

            // Iterate through matches and sum up the numbers
            foreach (Match match in matches)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }
    }
}
