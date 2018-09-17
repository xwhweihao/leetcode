using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode387
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dddccdbba";

            Console.WriteLine(FirstUniqChar(s));

            Console.ReadKey();
        }
        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(s[i]))
                {

                    keyValuePairs.Add(s[i], 1);
                }
                else
                {
                    keyValuePairs[s[i]]++;
                }


            }

            foreach (var item in keyValuePairs)
            {
                if (item.Value == 1)
                {
                    return s['a'];
                }
   
            }

            return -1;
        }
    }
}
