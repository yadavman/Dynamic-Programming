using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Common_Subsequence
{
    public class SequenceDP
    {
        private int[,] dp;
        public SequenceDP()
        {

        }

        public int GetLongestCommonSubsequenceCount(string x, string y, LCSMode mode)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Input values cannot be null");

            int n = x.Length;
            int k = y.Length;

            switch (mode)
            {
                case LCSMode.Recursive:
                    return GetLCSCountRecursive(x, y,n,k);
                    
                case LCSMode.RecursiveWithMemoization:
                    dp = new int[n+1,k+1];
                    //Initialize with -1 

                    for (int i = 0; i <= n; i++)
                    {
                        for (int j = 0; j <= k; j++)
                        {
                            dp[i, j] = -1;
                        }
                    }


                    return GetLCSCountRecursiveWithMemoization(x,y,n,k);

                case LCSMode.BottomUp:
                    return GetLCSCountBottomUp(x,y,n,k);
                default:
                    break;
            }
            throw new Exception("System error");
        }

        private int GetLCSCountRecursiveWithMemoization(string x, string y,int n,int k)
        {
            //Base Condition
            if (n ==0 || k == 0)
                return 0;

            if (dp[n, k] != -1)
                return dp[n, k];

            if (x[n - 1] == y[n - 1])
            {
                return dp[n, k]=1 + GetLCSCountRecursiveWithMemoization(x, y, n - 1, k - 1);
            }
            else
            {
                return dp[n, k]=Math.Max(GetLCSCountRecursiveWithMemoization(x, y, n, k - 1), GetLCSCountRecursiveWithMemoization(x, y, n - 1, k));
            }
            
        }

        private int GetLCSCountRecursive(string x, string y, int n, int k)
        {
            //Base Condition
            if (n == 0 || k == 0)
                return 0;

            if (x[n - 1] == y[n - 1])
            {
                return 1 + GetLCSCountRecursive(x, y, n - 1, k - 1);
            }
            else
            {
                return Math.Max(GetLCSCountRecursive(x, y, n, k - 1), GetLCSCountRecursive(x, y, n - 1, k));
            }
        }

        private int GetLCSCountBottomUp(string x, string y, int n, int k)
        {
            dp = new int[n + 1, k + 1];

            //Initialize we can do in the 2 lopps itself 

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    //Initialize
                    if(i==0 | j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }

                    if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            return dp[n, k];

        }

        //public method
        public string GetLCS(string x, string y)
        {
            return GetLCS(x,y,x.Length,y.Length);
        }

        //private method
        private string GetLCS(string x, string y, int n, int k)
        {
            dp = new int[n + 1, k + 1];

            //Initialize we can do in the 2 lopps itself 

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    //Initialize
                    if (i == 0 | j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }

                    if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            //back tracking to print the lcs

            char[] lcsArray = new char[dp[n,k]]; // we know the length of the LCS 
            int temp = dp[n, k]; //insert in opposite order so that we need not reverse again

            int e = n;
            int  f= k;
            while(e>0 && f > 0)
            {
                if (x[e - 1] == y[f - 1])
                {
                    lcsArray[temp-1] = x[e - 1];
                    temp--;
                    e--;
                    f--;
                }
                else
                {
                    //not equal than need to se where from we reached the place 
                    if (dp[e - 1, f] > dp[e, f - 1])
                    {
                        //then we came from [i-1,j]
                        e--;
                    }
                    else
                    {
                        //we came from [i,j-1]
                        f--;
                    }
                }
            }
            return new string(lcsArray);


        }
    }

    public enum LCSMode
    {
        Recursive,
        RecursiveWithMemoization,
        BottomUp
    }

    public enum LCSOperation
    {
        Count,
        Sequence
    }
}
