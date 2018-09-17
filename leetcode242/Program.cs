using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode242
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            string t = "ab";

            Console.WriteLine(IsAnagram(s, t));

            Console.ReadKey();
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs[s[i]]++;
                }
                else
                {
                    keyValuePairs.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (keyValuePairs.ContainsKey(t[i]))
                {
                    keyValuePairs[t[i]]--;
                }
            }

            foreach (var item in keyValuePairs)
            {
                if (item.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
