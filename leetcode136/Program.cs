using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode136
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 4, 1, 2, 1, 2 };

            Console.WriteLine(SingleNumber(nums));

            Console.ReadKey();
        }

        public static int SingleNumber(int[] nums)
        {
            //排序
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i=i+2)
            {
                if (i + 1 >= nums.Length)
                {
                    return nums[i];
                }

                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return -1;
        }
    }
}
