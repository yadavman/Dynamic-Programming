using System;
using System.Collections.Generic;
using System.Text;

namespace ShortestCommonSuperSequence
{
    /// <summary>
    /// Shortest Common Super Sequence
    /// </summary>
    public class SCS
    {
        public SCS()
        {

        }

        public int SCSCount(string x, string y)
        {
            int n = x.Length;
            int k = y.Length;

            int[,] dp = new int[n + 1, k + 1];

            //Write LCS code for count

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    //initialize
                    if (i == 0 || j == 0)
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
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }

                }
            }

            //return dp[n, k]; //this is lCs count
            //Console.WriteLine("dp count is {0}", dp[n, k]);
            return (n + k) - dp[n, k];

        }

        //I have duplicated code just for practice, users discretion is advised
        public string GetSCS(string x, string y)
        {
            int n = x.Length;
            int k = y.Length;

            int[,] dp = new int[n + 1, k + 1];

            //Write LCS code for count

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    //initialize
                    if (i == 0 || j == 0)
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
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }

                }
            }

            ///Need to backtrack to get the string printed
            int index = (n + k) - dp[n, k];
            char[] scsArray = new char[index];
            int temp = index;

            int p = n;
            int q = k;

            while (p > 0 && q > 0)
            {
                if (x[p - 1] == y[q - 1])
                {
                    scsArray[temp-1] = x[p - 1];
                    temp--;
                    p--;
                    q--;
                }
                else
                {
                    if (dp[p - 1, q] > dp[p, q - 1])
                    {
                        scsArray[temp - 1] = x[p - 1]; 
                        temp--;
                        p--;
                        
                       
                    }
                    else
                    {
                        scsArray[temp - 1] = y[q - 1];
                        temp--;
                        q--;    
                        
                    }

                }
            }

            while (p != 0)
            {
                scsArray[temp-1] = x[p-1];
                temp--;
                p--;
            }

            while (q != 0)
            {
                scsArray[temp-1] = y[q-1];
                temp--;
                q--;
            }

            return new string(scsArray);
        }
    }
}
