using System;

namespace ShortestCommonSuperSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shortest Common Super Sequence!");

            string y = "geek";
            string x = "eke";

            SCS scs = new SCS();
            Console.WriteLine("SCS count is {0}", scs.SCSCount(x, y));
            Console.WriteLine("SCS is {0}", scs.GetSCS(x, y));

            Console.Read();
            
        }
    }
}
