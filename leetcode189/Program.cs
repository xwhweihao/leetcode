using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode189
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var k = 2;

            Rotate(nums, k);

            Console.WriteLine(string.Join(",", nums));

            Console.ReadKey();
        }

        /// <summary>
        /// 简单移动，每次移动一位，效率低
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        //public static void Rotate(int[] nums, int k)
        //{
        //    var temp = 0;

        //    while (k > 0)
        //    {
        //        for (int i = nums.Length - 1; i >= 0; i--)
        //        {
        //            if (i == nums.Length - 1)
        //            {
        //                temp = nums[i];
        //            }
        //            else 
        //            {
        //                nums[i + 1] = nums[i];
        //                if(i==0)
        //                    nums[i] = temp;
        //            }
        //        }
        //        k--;
        //    }
        //}

        public static void Rotate(int[] nums, int k)
        {
            var num = k % nums.Length;
            var temp = new int[num];

            for (int i = nums.Length-1; i >= 0; i--)
            {
                if (nums.Length - i <= num)
                {
                    temp[nums.Length - i - 1] = nums[i];
                }
                else
                {
                    nums[i + num] = nums[i];
                }
            }

            for (int j = temp.Length-1; j >=0; j--)
            {
                nums[temp.Length - j - 1] = temp[j];
            }

        }


    }
}
