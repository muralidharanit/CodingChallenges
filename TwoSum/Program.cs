using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }

        static int[] TwoSum(int[] nums, int target)
        {
            // Dictionary to store the complement (target - current element) and its index
            Dictionary<int, int> complementIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // If complement is in the dictionary, return the indices
                if (complementIndexMap.ContainsKey(complement))
                {
                    return new int[] { complementIndexMap[complement], i };
                }

                // Otherwise, add the current element and its index to the dictionary
                complementIndexMap[nums[i]] = i;
            }

            // No solution found, return an empty array or handle it according to your requirements
            return new int[0];
        }
    }
}



//using System;

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {

//        var result = new List<int>();
//        for (int i = 0; i <= nums.Length - 1; i++)
//        {
//            for (int j = i; j <= nums.Length - 1; j++)
//            {
//                if (j != nums.Length - 1)
//                {
//                    int sum = nums[i] + nums[j + 1];

//                    if (sum == target)
//                    {
//                        result.Add(i);
//                        result.Add(j + 1);
//                        break;
//                    }
//                }

//            }

//            if (result.Count != 0)
//                break;
//        }

//        return result.ToArray();
//    }
//}