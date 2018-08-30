using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = 10;

            var nums1 = new int[] { 2, 5, 5, 11 };

            var nums3 = TwoSum(nums1, target);

            Console.WriteLine(string.Join(",", nums3));

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var number = target - nums[i];

                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[j]==number)
                    {
                        result.Add(i);
                        result.Add(j);

                        break;
                    }
                }

                if (result.Any())
                {
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
