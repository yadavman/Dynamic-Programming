using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Repating_Subsequence
{
    public class LongestRepeatingSubsequence
    {
        public LongestRepeatingSubsequence()
        {

        }

        public int LRSCount(string str)
        {
            int n = str.Length;

            int[,] dp = new int[n+1,n+1];

            for (int i = 0; i <=n; i++)
            {
                for (int j = 0; j <=n; j++)
                {
                    //Initailize
                    if(i==0 || j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }

                    //Apply LCS with restrcition that repeating char should not be at the same index

                    if (str[i-1]==str[j-1] && i!=j)
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[n, n];

        }

        //Repating coe for practice, others should appy common code 
        public string LRS(string str)
        {
            int n = str.Length;

            int[,] dp = new int[n + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    //Initailize
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }

                    //Apply LCS with restrcition that repeating char should not be at the same index

                    if (str[i - 1] == str[j - 1] && i != j)
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            int index = dp[n,n]; //LRS string
            char[] lrsArray = new char[index];
            int p = n;
            int q = n;

            while(p>0 && q > 0)
            {
                if(str[p-1]==str[q-1] && p != q)
                {
                    lrsArray[index - 1] = str[p - 1];
                    index--;
                    p--;
                    q--;
                }
                else
                {
                    if(dp[q,p-1]> dp[q-1, p])
                    {
                        p--;
                    }
                    else
                    {
                        q--;
                    }
                }
            }


            return new string(lrsArray);
        }
    }
}
