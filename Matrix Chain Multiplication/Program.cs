using System;

namespace Matrix_Chain_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Chain Multiplication!");

            //Given the size of matrixes in the array format 
            //where M(i) = A[i-1]*A[i]

            int[] arr = { 40, 20, 30, 10, 30 };

            //Matrx A1 size is 40*20
            //A2 is 20* 30
            //A3 is 30*10
            //A4 is 10*30

            // we nned to minimize the cost of matrix multiplication
            MCM mcm = new MCM();
            Console.WriteLine("Minimum cost of matrix multiplication is {0}",mcm.MinMCMCost(arr));

            Console.WriteLine("Minimum cost of matrix multiplication using memoized is {0}", mcm.MinMCMCostMemoized(arr));

            Console.WriteLine("Minimum cost of matrix multiplication using bottom up is {0}", mcm.MCMBottomUp(arr)); 

            Console.Read();
        }
    }
}
