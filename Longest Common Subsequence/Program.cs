using System;

namespace Longest_Common_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common Subsequence!");

            string x = "abcdgh";
            string y = "abedfhr";

            //op abdh
            SequenceDP sequenceDP = new SequenceDP();
            Console.WriteLine("LCS with recusrive way is {0}", sequenceDP.GetLongestCommonSubsequenceCount(x,y,LCSMode.Recursive));

            Console.WriteLine("LCS with recusrive/memoization way is {0}", sequenceDP.GetLongestCommonSubsequenceCount(x, y, LCSMode.RecursiveWithMemoization));

            Console.WriteLine("LCS with bottom up way is {0}", sequenceDP.GetLongestCommonSubsequenceCount(x, y, LCSMode.BottomUp));

            Console.Read();
        }
    }
}
