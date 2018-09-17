using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode007
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1534236469;

            Console.WriteLine(Reverse(num));

            Console.ReadKey();
        }

        public static int Reverse(int x)
        {
            long result=0;
            while (x != 0)
            {
                var num = x % 10;
                if (result > Int32.MaxValue / 10)
                {
                    return 0;
                }
                else if (result < Int32.MinValue / 10)
                {
                    return 0;
                }

                x = x / 10;

                result = result * 10 + num;
            }

        

            return (int)result;

        }
    }
}
