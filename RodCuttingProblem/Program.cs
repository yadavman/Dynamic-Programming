using System;

namespace RodCuttingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rod Cutting Problem!");

            int[] length = { 1, 2, 3, 4, 5, 6, 7, 8 }; //Possible ways to cut the Rod

            int[] price = { 3 , 5 ,  8,   9  ,10 , 17 , 17 , 20 }; // price for each length cut

            int rodlength = 8; //needed size of rod

            UnboundedKnapsack unboundedKnapsack = new UnboundedKnapsack();

            Console.WriteLine("Max profit is {0}",unboundedKnapsack.MaximimizeProfitForRodCutting(length,price,rodlength,length.Length));

            Console.Read();
            //Maximize the Profit 
        }
    }
}
