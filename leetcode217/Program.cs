using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode217
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = new int[] { 1, 2, 3, 4 };


            Console.WriteLine(ContainsDuplicate(nums));

            Console.ReadKey();
        }

        public static bool ContainsDuplicate(int[] nums)
        {

            return nums.Distinct().Count() != nums.Count();
        }
    }
}
