using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode344
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";

            Console.WriteLine(ReverseString(s));

            Console.ReadKey();
        }

        public static string ReverseString(string s)
        {

            if (string.IsNullOrEmpty(s)||s.Length==1)
            {
                return s;
            }

            char[] result = s.ToCharArray();

            for (int i = 0; i < s.Length / 2; i++)
            {
                int temp = result[i]^ result[s.Length - 1 - i];
                result[i] = (char)(result[i] ^ temp);
                result[s.Length - 1 - i] = (char)(result[s.Length - 1 - i] ^ temp);

            }

            return new string(result);
        }
    }
}
