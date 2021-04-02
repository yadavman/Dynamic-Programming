using System;
using System.Collections.Generic;
using System.Text;

namespace _0_1_Knapsack
{
    public class KnapsackRecursive
    {
        private int[] weight;
        private int[] value;
        private int capacity;
        private int size = 0;
        
        public KnapsackRecursive(int[] weight, int[] value, int capacity)
        {
            if (weight?.Length <= 0 || value?.Length <= 0)
                throw new ArgumentNullException("wirght ot the value array cannot be null");

            this.weight = weight;
            this.value = value;
            this.capacity = capacity;
            this.size = weight.Length;
        }

        public int RunKnapsack()
        {
            return GetMaximumProfit(this.size, this.capacity);
        }
        private int GetMaximumProfit(int size,int capacity)
        {
            if (size <= 0 || capacity<=0)
                return 0;

            if (weight[size - 1] > capacity)
            {
                return GetMaximumProfit(size - 1, capacity);
            }
            else
            {
                //can include or can chose not to include as we have choice
                //profit will be max of the choices
                return Math.Max(value[size - 1] + GetMaximumProfit(size - 1, capacity - weight[size - 1]), GetMaximumProfit(size - 1, capacity));
            }

            

        }
    }
}
