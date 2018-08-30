using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode122
{
    class Program
    {
        static void Main(string[] args)
        {
            //[7,1,5,3,6,4]
            var nums = new int[] { 6, 1, 3, 2, 4, 7 };

            Console.WriteLine(MaxProfit(nums));

            Console.ReadKey();
        }
        public static int MaxProfit(int[] prices)
        {
            var number = 0;

            var min = -1;
            var max = -1;

            for (int i = 0; i < prices.Length-1; i++)
            {
                if (prices[i] < prices[i + 1]&&min==-1)
                {
                    min = prices[i];
                }
                else if(prices[i]>prices[i+1]&&min!=-1)
                {
                    max = prices[i];
                }


                if (min != -1 && max != -1)
                {
                    number += max - min;

                    max = -1;
                    min = -1;
                }
            }

            if (min != -1)
            {
                number += prices.Last() - min;
            }

            return number;
        }
    }
}
