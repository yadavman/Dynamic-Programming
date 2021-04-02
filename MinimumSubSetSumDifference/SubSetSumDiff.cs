using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinimumSubSetSumDifference
{
    public class SubSetSumDiff
    {
        public SubSetSumDiff()
        {

        }

        //Same coe as finding subset sum
        public int GetMinSubsetSumDiff(int[] arr)
        {
            int arrSum = arr.Sum();

            int sum = arrSum / 2;

            bool[,] dp = new bool[arr.Length + 1, sum + 1];

            for (int i = 0; i < arr.Length + 1; i++)
                dp[i, 0] = true;

            for (int i = 1; i <= sum; i++)
                dp[0, i] = false ;

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

                        dp[n, k] = dp[n - 1, k - arr[n - 1]] || (dp[n - 1, k]);

                    }
                }
            }

            int min = 0;

            for(int j= sum; j >0; j--)
            {
                if (dp[arr.Length,j])
                {
                    min = arrSum - 2 * j;
                    break;
                }
                
            }



            return min;
            //return dp[arr.Length, sum];
        }
    }
}
