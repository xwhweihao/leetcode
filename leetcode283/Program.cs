using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode283
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 0, 1, 0, 3, 12 };

            MoveZeroes(nums1);

            Console.WriteLine(string.Join(",", nums1));

            Console.ReadKey();
        }
        public static void MoveZeroes(int[] nums)
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp.Add(nums[i]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= temp.Count - 1)
                {
                    nums[i] = temp[i];
                }
                else
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
