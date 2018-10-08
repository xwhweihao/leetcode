using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode125
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("0P"));

            Console.ReadKey();
        }

        static public bool IsPalindrome(string s)
        {
            char[] alphabet = new char[36];

            System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();

            for (int i = 48; i < 58; i++)
            {
                byte[] byteArray = new byte[] { (byte)i };
                alphabet[i - 48] = asciiEncoding.GetChars(byteArray)[0];
            }

            for (int i = 97; i < 123; i++)
            {
                byte[] byteArray = new byte[] { (byte)i };
                alphabet[i + 10 - 97] = asciiEncoding.GetChars(byteArray)[0];
            }

            char[] c = s.ToLower().ToCharArray();

            var filer = c.Where(w => alphabet.Contains(w)).ToArray();

            for (int i = 0; i < filer.Length / 2; i++)
            {
                if (filer[i] != filer[filer.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
