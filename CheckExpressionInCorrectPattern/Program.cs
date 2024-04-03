using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckExpressionInCorrectPattern
{
    internal class Program
    {
        static bool IsCorrectPattern(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (IsOpeningBracket(ch))
                {
                    stack.Push(ch);
                }
                else if (IsClosingBracket(ch))
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        static bool IsOpeningBracket(char ch)
        {
            return ch == '{' || ch == '[' || ch == '(';
        }

        static bool IsClosingBracket(char ch)
        {
            return ch == '}' || ch == ']' || ch == ')';
        }

        static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '(' && closing == ')');
        }

        static void Main()
        {
            string input = "{[{()}]}";
            bool isCorrectPattern = IsCorrectPattern(input);

            Console.WriteLine($"Is the pattern correct? {isCorrectPattern}");
        }
    }
}
