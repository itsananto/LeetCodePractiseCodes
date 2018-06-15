using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class TotalNQueensSolution
    {
        public TotalNQueensSolution()
        {
            TotalNQueens(5);
        }

        int solutions;

        public void Spread(bool[,] board, int row, int col, int n)
        {
            for (int i = 0; i < n; i++)
            {
                board[row, i] = true;
                board[i, col] = true;
            }

            int r = row + 1, c = col + 1;
            while (r <= n - 1 && c <= n - 1)
            {
                board[r, c] = true;
                r++; c++;
            }

            r = row - 1;
            c = col - 1;
            while (r >= 0 && c >= 0)
            {
                board[r, c] = true;
                r--; c--;
            }

            r = row - 1;
            c = col + 1;
            while (r >= 0 && c <= n - 1)
            {
                board[r, c] = true;
                r--; c++;
            }

            r = row + 1;
            c = col - 1;
            while (r <= n - 1 && c >= 0)
            {
                board[r, c] = true;
                r++; c--;
            }
        }

        public void Backtrack(bool[,] board, int n, int row)
        {
            for (int col = 0; col < n; col++)
            {
                if (board[row, col] == false && row != n - 1) // not occupied
                {
                    var clone = (bool[,])board.Clone();
                    clone[row, col] = true;
                    Spread(clone, row, col, n);
                    Backtrack(clone, n, row + 1);
                }
                else if (board[row, col] == false && row == n - 1)
                {
                    ++solutions;
                }
            }
        }

        public int TotalNQueens(int n)
        {
            solutions = 0;
            Backtrack(new bool[n, n], n, 0);
            return solutions;
        }
    }
}
