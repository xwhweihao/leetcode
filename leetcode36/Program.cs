using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode36
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] chars = new char[,] {
                {'8','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'} };



            Console.WriteLine(IsValidSudoku(chars));


            Console.ReadKey();
        }

        public static bool IsValidSudoku(char[,] board)
        {

            for (int i = 0; i < 9; i++)
            {
                List<char> row = new List<char>();
                List<char> col = new List<char>();

                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        if (row.Contains(board[i, j]))
                        {
                            return false;
                        }
                        row.Add(board[i, j]);
                    }

                    if (board[j, i] != '.')
                    {
                        if (col.Contains(board[j, i]))
                        {
                            return false;
                        }
                        col.Add(board[j, i]);
                    }

                    if (j % 3 == 0 & i % 3 == 0)
                    {
                        List<char> rge = new List<char>();

                        for (int k = i; k < i+3; k++)
                        {
                            for (int m = j; m < j+3; m++)
                            {
                                if (board[k, m] != '.')
                                {
                                    if (rge.Contains(board[k, m]))
                                    {
                                        return false;
                                    }
                                    rge.Add(board[k, m]);
                                }
                            }
                        }


                    }
                }

            }

           

            return true;
        }
    }
}
