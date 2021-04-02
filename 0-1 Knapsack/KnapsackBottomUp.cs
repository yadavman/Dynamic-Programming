using System;
using System.Collections.Generic;
using System.Text;

namespace _0_1_Knapsack
{
    public class KnapsackBottomUp
    {
        private int[] weight;
        private int[] value;
        private int capacity;
        private int size = 0;
        //private int profit = 0;

        private int[,] dp;
        public KnapsackBottomUp(int[] weight, int[] value, int capacity)
        {
            if (weight?.Length <= 0 || value?.Length <= 0)
                throw new ArgumentNullException("weight or the value array cannot be null");

            this.weight = weight;
            this.value = value;
            this.capacity = capacity;
            this.size = weight.Length;
            dp = new int[this.size + 1, capacity + 1];
        } 

        public int RunKnapsack()
        {
           
            return GetMaximumProfit(this.size, this.capacity);
        }
        private int GetMaximumProfit(int size, int capacity)
        {
            for (int s = 0; s < dp.GetLength(0); s++)
            {
                for (int w = 0; w < dp.GetLength(1); w++)
                {
                    //this step can be done outside as well.. 
                    //bu since we have 2 loops here we can use this to initialize the values 
                    //that will be extra 2 loops to initialize the values which can be avoided
                    if (s == 0 || w == 0)
                    {
                        dp[s, w] = 0;
                        continue;
                    }
                        

                    if (weight[s-1]>w)
                    {
                        dp[s,w] = dp[s - 1,w];
                    }
                    else
                    {
                        dp[s, w] = Math.Max(value[s - 1] + dp[s - 1, w - weight[s - 1]], dp[s - 1, w]);
                    }
                } 
            }
            return dp[this.size, capacity];


        }
    }
}
