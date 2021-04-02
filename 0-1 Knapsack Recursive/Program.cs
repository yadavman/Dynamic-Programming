
using System;

namespace _0_1_Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0-1 Knapsack Problem!");
            //Problem Statement of 0-1 knapsack
            //Given a Weight array and a value arary and a fix size of bag how can we put the wieghts in the bag so that profit is maximized.


            int[] value = { 60,100,120};
            int[] weight = { 10,20,30 };

            int capacity = 50;


            KnapsackRecursive knapscak = new KnapsackRecursive(weight,value,capacity);

            Console.WriteLine("maximum profit using recursive is {0}", knapscak.RunKnapsack());

            KnacksackMemoization knapsackMemoization = new KnacksackMemoization(weight, value, capacity);

            Console.WriteLine("maximum profit using memoization  is {0}", knapsackMemoization.RunKnapsack());

            KnapsackBottomUp knapsackBottomup = new KnapsackBottomUp(weight, value, capacity);

            Console.WriteLine("maximum profit using bottom up is {0}", knapsackBottomup.RunKnapsack());
            Console.Read();
        }
    }
}
