using System;

namespace SubSet_Sum_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SubSet Sum Count!");

            int[] arr = { 2, 3, 5,7, 8, 10 };
            //int sum = 10;

            //PS: is ther any subset whose sum is equal to the given sum
            Console.WriteLine("Given Array is ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SubSetSum subsetSum = new SubSetSum();

            Console.WriteLine("Subset is {0} with sum {1}", subsetSum.IsSubsetPresent(arr, 167) ? "Present" : "Not Present", 167);

            Console.WriteLine("Subset is {0} with sum {1}", subsetSum.IsSubsetPresent(arr, 11) ? "Present" : "Not Present", 11);

            Console.WriteLine("Subset is {0} with sum {1}", subsetSum.IsSubsetPresent(arr, 5) ? "Present" : "Not Present", 5);

            Console.WriteLine("Count of subset with given sum is {0}",subsetSum.CountSubSetForSum(arr,10));

            Console.Read();
        }
    }
}
