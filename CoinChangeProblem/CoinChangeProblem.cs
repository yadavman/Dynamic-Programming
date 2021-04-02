using System;
using System.Collections.Generic;
using System.Text;

namespace CoinChangeProblem
{
    public class CoinChangeProblem
    {
        public CoinChangeProblem()
        {

        }

        public int GetMaxCoinChangeWays(int[] arr,int sum,int size)
        {
            int[,] dp = new int[size + 1, sum + 1];

            //Initialize
            for (int i = 0; i <= size; i++)
                dp[i, 0] = 1;
            for (int j = 1; j <= sum; j++)
                dp[0, j] = 0;

            //Logic for Max ways of coin change

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (arr[i-1]>j)
                    {
                        //we cant process this item 
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        //We have a choice whether to include or not
                        dp[i, j] = dp[i - 1, j] + dp[i, j - arr[i - 1]];
                    }
                }
            }


            return dp[size,sum];
        }

        public int GetMinCoinForSum(int[] arr, int sum, int size)
        {
            int[,] dp = new int[size + 1, sum + 1];
            //Initialize

            for(int i = 0; i <= sum; i++)
            {
                dp[0, i] = int.MaxValue-1;
                dp[1, i] = (i % arr[0]) == 0 ? (i / arr[0]) : int.MaxValue-1;
            }
            for (int j = 1; j <= size; j++)
            {
                dp[j, 0] = 0;
            }

            for (int i = 2; i <= size; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (arr[i-1] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j], 1 + dp[i, j - arr[i - 1]]);
                    }
                }
            }

            return dp[size, sum];

        }
    }
}
