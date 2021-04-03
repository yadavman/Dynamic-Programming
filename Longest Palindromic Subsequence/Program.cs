using System;

namespace Longest_Palindromic_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Palindromic Subsequence!");

            string x = "agbcba";
            //1 solution is to to revesre the string and use both the string to get Longest LCS
            //her we are trying to run the LCS on the same string

            LongestPalindromicSubsequence lps = new LongestPalindromicSubsequence();

            Console.WriteLine("Longest Palindromic Subsequence count recursive way is {0}",lps.LPSCount(x,Mode.Recursive));

            Console.WriteLine("Longest Palindromic Subsequence count is {0}", lps.LPSCount(x, Mode.DP));

            Console.WriteLine("Longest Palindromic Subsequence is {0}", lps.GetLPS(x));//can be multiple

            Console.Read();
        }
    }
}
