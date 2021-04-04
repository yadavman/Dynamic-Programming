using System;

namespace Palindrome_Partitioining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "ababbbabbababa";


            PalindromePartitoining pp = new PalindromePartitoining();

            Console.WriteLine("Minimum count to make each partition as palindrome is {0}",pp.PalindromePartitionCount(str));

            Console.WriteLine("Minimum count to make each partition as palindrome with memoization is {0}", pp.PalindromePartitionCountMemo(str));

            Console.Read();
        }
    }
}
