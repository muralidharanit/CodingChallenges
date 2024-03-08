using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNoSameCharOccuerenceInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> charCount = new Dictionary<string, int>();

            string input = "aeiouaabbbbbbcdddss12e23334a45a11";

            for (int i = 0; i <= input.Length-1; i++)
            {
                if (!charCount.ContainsKey(input[i].ToString()))
                {
                    charCount.Add(input[i].ToString(), 1);

                    for (int j = input.Length - 1; j >= i+1; j--)
                    {
                        if (input[i].ToString() == input[j].ToString())
                        {
                            charCount[input[i].ToString()]++;
                        }
                    }
                }                               
            }

            foreach (KeyValuePair<string, int> entry in charCount)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            Console.ReadLine();
        }
    }
}
