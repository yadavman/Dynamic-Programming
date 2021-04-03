using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Palindromic_Subsequence
{
    public class LongestPalindromicSubsequence
    {
        public LongestPalindromicSubsequence()
        {

        }

        public int LPSCount(string x, Mode mode=Mode.DP)
        {
            switch (mode)
            {
                case Mode.Recursive:
                    return LPSCountRecursive(x,0,x.Length-1);
                case Mode.DP:
                    return LPSCountDP(x);
                default:
                    break;
            }
            return 0;
        }

        private int LPSCountRecursive(string x,int i , int j)
        {
            //base condition
            if (i == j)
                return 1;

            if (x[i]==x[j] && j == i + 1)
                return 2;

            if (x[i] == x[j])
            {
                return 2 + LPSCountRecursive(x, i + 1, j - 1);
            }
            else
            {
                return Math.Max(LPSCountRecursive(x, i, j - 1), LPSCountRecursive(x, i + 1, j));
            }  
        }

        private int LPSCountDP(string x)
        {
            int n = x.Length;
            int i, j, cl;

            // Create a table to store results
            // of subproblems
            int[,] L = new int[n, n];

            // Strings of length 1 are
            // palindrome of lentgh 1
            for (i = 0; i < n; i++)
                L[i, i] = 1;
            for (cl = 2; cl <= n; cl++)
            {
                for (i = 0; i < n - cl + 1; i++)
                {
                    j = i + cl - 1;

                    if (x[i] == x[j] && cl == 2)
                        L[i, j] = 2;
                    else if (x[i] == x[j])
                        L[i, j] = L[i + 1, j - 1] + 2;
                    else
                        L[i, j] =
                         Math.Max(L[i, j - 1], L[i + 1, j]);
                }
            }

            return L[0, n - 1];
        }
        public string GetLPS(string x)
        {
            return null;
        }
    }

    public enum Mode
    {
        Recursive,
        DP
    }
}
