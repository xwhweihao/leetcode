using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] chars = new int[,] {
                {7,4,1},
                {8,5,2},
                {9,6,3},};

            Rotate(chars);

            Console.ReadKey();
        }

        /// <summary>
        /// 效率较低
        /// </summary>
        /// <param name="matrix"></param>
        public static void Rotate(int[,] matrix)
        {
            var length = matrix.Length;

            var n = Convert.ToInt32(Math.Sqrt(length));

            var datalist = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(matrix[i, j]);
                }
                datalist.Add(row);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = datalist[n - 1 - i][j];
                }
            }
        }


    }
}
