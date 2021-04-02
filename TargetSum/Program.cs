using System;

namespace TargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Target Sum!");

            int[] arr = { 1, 1, 2, 3 };

            int sum = 1;

            //Problem Statement
            //We are allowed to chnage the sign of the elements in the array to - or + and count the number of ways equal to given sum;
            //this is same as finding subset sum of (TotalSum+GivenSum)/2)
            //s1-s2= GivenSum
            //s1+s2=totalSum
            //s1= (TotalSum + GivenSum) / 2)
        }
    }
}
