using System;

namespace MinimumSubSetSumDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum Subset Sum Difference");
            Console.WriteLine("SubSet Sum Count!");

            int[] arr = { 1,6,11,5 };
            //int sum = 10;

            //PS: is ther any subset whose sum is equal to the given sum
            Console.WriteLine("Given Array is ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SubSetSumDiff subsetSumDiff = new SubSetSumDiff();

            Console.WriteLine("Mimimum subset sum diff is {0}", subsetSumDiff.GetMinSubsetSumDiff(arr));

            Console.Read();
        }
    }
}
