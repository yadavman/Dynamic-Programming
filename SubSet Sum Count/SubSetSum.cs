using System;
using System.Collections.Generic;
using System.Text;

namespace SubSet_Sum_Count
{
    public class SubSetSum
    {
        public SubSetSum()
        {

        }

        public int CountSubSetForSum(int[] arr, int sum)
        {
            int[,] dp = new int[arr.Length + 1, sum + 1];
    
            for (int i = 0; i < arr.Length + 1; i++)
                dp[i, 0] = 1;

            for (int i = 1; i <= sum; i++)
                dp[0, i] = 0;


            for (int n = 1; n < dp.GetLength(0); n++)
            {
                for (int k = 1; k < dp.GetLength(1); k++)
                {


                    if (arr[n - 1] > k)
                    {
                        //cannot include in the choice
                        dp[n, k] = dp[n - 1, k];
                    }
                    else
                    {
                        //we have choice either to include or not to include
                        //when include we need to reduce the sum with the value in the array else go to next element

                        dp[n, k] = (dp[n - 1, k - arr[n - 1]]) + (dp[n - 1, k]);

                    }
                }
            }
            return dp[arr.Length, sum];
        }
        public bool IsSubsetPresent(int[] arr, int sum)
        {
            return CountSubSetForSum(arr, sum) > 0;
            
        }
    }
}
