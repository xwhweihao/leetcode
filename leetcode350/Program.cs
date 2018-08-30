using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode350
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };

            var nums3 = Intersect(nums1, nums2);

            Console.WriteLine(string.Join(",",nums3));

            Console.ReadKey();
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> temp = new List<int>();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(nums1[i]))
                {
                    keyValuePairs.Add(nums1[i], 1);
                }
                else
                {
                    keyValuePairs[nums1[i]] ++;
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums2[i])&&keyValuePairs[nums2[i]]>0)
                {
                    keyValuePairs[nums2[i]]--;
                    temp.Add(nums2[i]);
                }
            }

            return temp.ToArray();
        }
    }
}
