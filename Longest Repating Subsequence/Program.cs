using System;

namespace Longest_Repating_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Repeating Subeequence!");

            string str = "aabebcdd";
            //o/p abd and count 3


            LongestRepeatingSubsequence lps = new LongestRepeatingSubsequence();

            Console.WriteLine("Longest Repeating Subsequence Count is {0}",lps.LRSCount(str));

            Console.WriteLine("Longest Repeating Subsequence  is {0}", lps.LRS(str));
            Console.Read();
        }
    }
}
