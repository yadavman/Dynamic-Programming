using System;
using System.Collections.Generic;
using System.Text;

namespace RodCuttingProblem
{
    public class UnboundedKnapsack
    {
        public UnboundedKnapsack()
        {

        }

        public int MaximimizeProfitForRodCutting(int[] length,int[] price, int rodLength,int size)
        {
            int[,] dp = new int[size + 1, rodLength + 1];

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= rodLength; j++)
                {
                    //Initialized at 1 go
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }
                        

                    if (length[i-1]>j)
                    {
                        //You cannot process this item
                        dp[i, j] = dp[i - 1, j]; 
                    }
                    else
                    {
                        //We have a choice 

                        dp[i, j]= Math.Max(dp[i - 1, j], price[i - 1] + dp[i, j - length[i - 1]]);

                    }
                }
            }
            return dp[size,rodLength];
        }
    }
}
