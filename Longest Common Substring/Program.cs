using System;

namespace Longest_Common_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common Substring!");

            string x = "acdek";
            string y = "adek";

            LongestCommonSubstring lcs = new LongestCommonSubstring();
            Console.WriteLine("Count of Longest common substring is {0}", lcs.CountLongestCommonSubstring(x,y));


            Console.WriteLine("Longest common substring is {0}", lcs.GetLongestCommonSubstring(x, y));

            Console.Read();
        }
    }
}
