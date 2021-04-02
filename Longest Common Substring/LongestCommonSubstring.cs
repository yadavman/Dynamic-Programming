using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_Common_Substring
{
    public class LongestCommonSubstring
    {
        public LongestCommonSubstring()
        {

        }

        public int CountLongestCommonSubstring(string x, string y)
        {
            int result = 0;

            int n = x.Length;
            int k = y.Length;

            int[,] dp = new int[n + 1, k + 1];

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
                        result = Math.Max(result, dp[i, j]);
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            return result;
            
        }

        public string GetLongestCommonSubstring(string x, string y)
        {
            int n = x.Length; //size of string 1
            int k = y.Length; //size of string 2
            int count = 0;
            int row = 0;
            int col = 0;

            int[,] dp = new int[n + 1, k + 1];

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
                        //count = Math.Max(count, dp[i, j]);
                        if(count< dp[i, j])
                        {
                            count = dp[i, j];
                            row = i;
                            col = j;
                        }
                    } 
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }


            //backtrack to find the maximum
            

            if (count == 0)
            {
                return "No Common Substring";
            }

            char[] lcsArray = new char[count];
            int temp = count;

            while (dp[row, col]>0)
                {
                    lcsArray[temp - 1] = x[row-1];
                    temp--;
                    row--;
                    col--;
                }

            return new String(lcsArray);
        }
    }
}
