using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome_Partitioining
{
    public class PalindromePartitoining
    {
        private int[,] dp;
        public PalindromePartitoining()
        {

        }
        /// <summary>
        /// No of Partitions to make each string palindrome
        /// </summary>
        /// <returns></returns>
        public int PalindromePartitionCount(string str)
        {
            return PalindromePartitionCount(str,0,str.Length-1);
        }
        public int PalindromePartitionCountMemo(string str)
        {
            int n = str.Length;
            dp = new int[n, n];
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return PalindromePartitionCountMemo(str, 0, n - 1);
        }

        private int PalindromePartitionCountMemo(string str, int i, int j)
        {
            if (i >= j || IsPalindrome(str, i, j))
                return 0;

            int min = int.MaxValue;

            if (dp[i,j]!=-1)
            {
                return dp[i, j];
            }
            for (int k = i; k < j; k++)
            {
                //if the partition created 2 palindromes then proceed else next
                int left= int.MaxValue;
                if (dp[i, k] == -1)
                {
                    left = PalindromePartitionCountMemo(str, i, k);
                }
                else
                {
                    left = dp[i, k];
                }

                int right = int.MaxValue;

                if (dp[k+1, j] == -1)
                {
                    right = PalindromePartitionCountMemo(str, k + 1, j);
                }
                else
                {
                    right = dp[k + 1, j];
                }

                int count = 1 + left+right;
                if (count < min)
                {
                    dp[i, j] = count;
                    min = count;
                }
                    
            }

            return min;
        }
        private int PalindromePartitionCount(string str,int i, int j)
        {
            if (i >= j || IsPalindrome(str,i,j))
                return 0;

            int min = int.MaxValue;

            for (int k = i; k < j; k++)
            {
                //if the partition created 2 palindromes then proceed else next
                
                    int count = 1 + PalindromePartitionCount(str,i,k) + PalindromePartitionCount(str,k+1,j);
                    if (count < min)
                        min = count; 
            }

            return min;
        }
 
        static bool IsPalindrome(string str, int i, int j)
        {
            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
