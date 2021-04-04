using System;
using System.Collections.Generic;
using System.Text;

namespace SequencePatternMatching
{
    public class SequencePatternMatching
    {
        public SequencePatternMatching()
        {

        }
        /// <summary>
        /// Checks whether the First Sequence is present in the 2nd or not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsSequencePresent(string x, string y)
        {
            int n = x.Length;
            int k = y.Length;
            if (n > k)
                return false;
            if (n == k && x.Equals(y))
                return true;

            //Else try to find

            bool[,] dp = new bool[n + 1, k + 1];

            for (int i = 1; i <=n; i++)
            {
                dp[i, 0] = false;
            }
            for (int j = 0; j <= k; j++)
            {
                dp[0, j] = true;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=k; j++)
                {
                    
                    if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                }
            }

            return dp[n,k];
        }
    }
}
