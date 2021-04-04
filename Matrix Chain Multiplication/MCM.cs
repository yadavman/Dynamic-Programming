using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_Chain_Multiplication
{
    public class MCM
    {
        private int[,] dp;
        public MCM()
        {

        }
        public int MinMCMCost(int[] arr)
        {
            return MatrixChainOrder(arr,1,arr.Length-1);
        }

        private int MatrixChainOrder(int[] arr, int i , int j)
        {
            //Base Conditions
            if (i >= j)
                return 0;

            int min = int.MaxValue;

            for (int k = i; k < j; k++)
            {
                int count = arr[i - 1] * arr[k] * arr[j] + MatrixChainOrder(arr, i, k) + MatrixChainOrder(arr, k + 1, j);
                if (count < min)
                    min = count;
            }

            return min;

        }


        public int MinMCMCostMemoized(int[] arr)
        {
            dp = new int[arr.Length, arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= arr.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return MatrixChainOrderMemo(arr, 1, arr.Length - 1);
        }

        private int MatrixChainOrderMemo(int[] arr, int i, int j)
        {
            //Base Conditions
            if (i >= j)
                return 0;

            if (dp[i, j] != -1)
                return dp[i, j];

            int min = int.MaxValue;

            for (int k = i; k < j; k++)
            {
                dp[i, k] = MatrixChainOrderMemo(arr, i, k);
                dp[k + 1, j] = MatrixChainOrderMemo(arr, k + 1, j);
                int count =arr[i - 1] * arr[k] * arr[j] + MatrixChainOrderMemo(arr, i, k) + MatrixChainOrderMemo(arr, k + 1, j);
                if (count < min)
                    min = count;
            }

            return min;

        }

        public int MCMBottomUp(int[] p)
        {
            int n= p.Length;
         
            int[,] dp = new int[n, n];

            int  j, mn;

            for (int i = 1; i < n; i++)
                dp[i, i] = 0;

            // L is chain length.
            for (int L = 2; L < n; L++)
            {
                for (int i = 1; i < n - L + 1; i++)
                {
                    j = i + L - 1;
                    if (j == n)
                        continue;
                    dp[i, j] = int.MaxValue;
                    for (int k = i; k <= j - 1; k++)
                    {
                        // q = cost/scalar multiplications
                        mn = dp[i, k] + dp[k + 1, j]
                            + p[i - 1] * p[k] * p[j];
                        if (mn < dp[i, j])
                           dp[i, j] =mn;
                    }
                }
            }

            return dp[1, n - 1];
        }
    }
}
