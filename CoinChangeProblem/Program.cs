using System;

namespace CoinChangeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin Change Problem!");

            int[] arr = { 1, 2, 3 };
            int sum = 5;

            //no of ways to get the sum 5 , can use the array values any number of time

            CoinChangeProblem coinChange = new CoinChangeProblem();
            Console.WriteLine("Max no of ways is {0}", coinChange.GetMaxCoinChangeWays(arr, sum, arr.Length));

            Console.WriteLine("Min no of coins is {0}", coinChange.GetMinCoinForSum(arr, sum, arr.Length));
            Console.Read();
        }
    }
}
