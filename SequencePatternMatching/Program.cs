using System;

namespace SequencePatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seuqnece Pattern Matching!");
            //Or we can simply do LCS of two strings and if LCS length is equal to first string Length then the string itself exists

            string a = "AXM";
            string b = "ADXCPY";
            string str1 = "gksrek";
            string str2 = "geeksforgeeks";
            SequencePatternMatching spm = new SequencePatternMatching();

            Console.WriteLine("The first sequence is {0}",spm.IsSequencePresent(a,b)?"Present":"Not Present");

            Console.WriteLine("The first sequence is {0}", spm.IsSequencePresent(str1, str2) ? "Present" : "Not Present");
            Console.Read();
        }
    }
}
