using System;
using System.Collections.Generic;
using System.Text;

namespace _0_1_Knapsack
{
    public class KnacksackMemoization
    {
        private int[] weight;
        private int[] value;
        private int capacity;
        private int size = 0;
        //private int profit = 0;

        private int[,] memo;
        public KnacksackMemoization(int[] weight, int[] value, int capacity)
        {
            if (weight?.Length <= 0 || value?.Length <= 0)
                throw new ArgumentNullException("weight or the value array cannot be null");

            this.weight = weight;
            this.value = value;
            this.capacity = capacity;
            this.size = weight.Length;
            memo = new int[this.size + 1, capacity + 1];
        }

        public int RunKnapsack()
        {
            //form a 2D matrix of size [n+1][w+1] to store the values at each calc and reuse it

            //Initialize the values with -1

            for (int i = 0; i < memo.GetLength(0); i++)
            {
                for (int j = 0; j < memo.GetLength(1); j++)
                {
                    memo[i, j] = -1;
                }
            }


            return GetMaximumProfit(this.size, this.capacity);
        }
        private int GetMaximumProfit(int size, int capacity)
        {
            if (size <= 0 || capacity <= 0)
                return 0;
            //if already data exists solved return that from memo
            if (memo[size - 1, capacity] != -1)
            {
                return memo[size - 1, capacity];
            }

            if (weight[size - 1] > capacity)
            {
                return memo[size - 1, capacity] = GetMaximumProfit(size - 1, capacity);
            }
            else
            {
                //can include or can chose not to include as we have choice
                //profit will be max of the choices
                return memo[size - 1, capacity] = Math.Max(value[size - 1] + GetMaximumProfit(size - 1, capacity - weight[size - 1]), GetMaximumProfit(size - 1, capacity));
            }



        }
    }
}
