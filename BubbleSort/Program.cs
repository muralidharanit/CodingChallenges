using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        public enum SortOrder
        {
            ASC,
            DESC,
        }

        static void Main(string[] args)
        {
            int[] array = { 73, 57, 49, 99, 133, 20, 1, 1, 20, 0 };

            var asc = GetSortedItems(array, SortOrder.ASC);
            var desc = GetSortedItems(array, SortOrder.DESC);
        }

        public static int[] GetSortedItems(int[] input, SortOrder order = SortOrder.ASC)
        {
            for (int i = 0; i<= input.Length-1; i++ )
            {
                for (int j = 0; j <= input.Length - 2; j++)
                {
                    if (SortCondition(order, input[j], input[j+1]))
                    {
                        int temp = input[j+1];
                        input[j+1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        public static bool SortCondition(SortOrder order, int x, int y)
        {
            if(SortOrder.ASC == order)
            {
                return x > y;
            }
            else if(SortOrder.DESC == order)
            {
                return x < y;
            }
            return false;
        }
    }
}


