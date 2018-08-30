using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode66
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 9, 9, 9 };

            var nums3 = PlusOne(nums1);

            Console.WriteLine(string.Join("", nums3));

            Console.ReadKey();
        }

        public static int[] PlusOne(int[] digits)
        {
            if (digits.Last() != 9)
            {
                digits[digits.Length - 1]++;

                return digits;
            }

            for (int i = digits.Length-1; i >= 0 ; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }

            var result = new List<int>();

            if (digits.First() == 0)
            {
                result.Add(1);
                result.AddRange(digits);
            }

            return result.ToArray();

        }
    }
}
